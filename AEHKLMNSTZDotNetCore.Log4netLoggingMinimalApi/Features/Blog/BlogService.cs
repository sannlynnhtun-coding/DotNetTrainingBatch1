using AEHKLMNSTZDotNetCore.Log4netLoggingMinimalApi;
using AEHKLMNSTZDotNetCore.Log4netLoggingMinimalApi.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Text.Json;

namespace AEHKLMNSTZDotNetCore.Log4netLoggingMinimalApi.Features.Blog;

public static class BlogService
{
    public static void AddBlogService(this IEndpointRouteBuilder app)
    {
        app.MapGet("/blog/{pageNo}/{pageSize}", async ([FromServices] AppDbContext db, [FromServices] ILogger<Program> _logger, int pageNo, int pageSize) =>
        {
            var lst = await db.Blogs
                .AsNoTracking()
                .Skip((pageNo - 1) * pageSize)
                .Take(pageSize)
                .ToListAsync();
            _logger.LogInformation("Blog List Response => " + JsonSerializer.Serialize(lst));
            return lst;
        })
        .WithName("GetBlogs")
        .WithOpenApi();

        app.MapPost("/blog", async ([FromServices] AppDbContext db,[FromServices] ILogger<Program> _logger, BlogDataModel blog) =>
        {
            _logger.LogInformation("Blog Save Request Model => " +  blog);
            await db.Blogs.AddAsync(blog);
            int result = await db.SaveChangesAsync();

            string message = result > 0 ? "Saving Successful." : "Saving Failed.";
            _logger.LogInformation("Blog Save Response Message => " + message);
            return Results.Ok(new BlogResponseModel
            {
                Data = blog,
                IsSuccess = result > 0,
                Message = message
            });
        })
       .WithName("CreateBlog")
       .WithOpenApi();

        app.MapPut("/blog/{id}", async ([FromServices] AppDbContext db,[FromServices] ILogger<Program> _logger, int id, BlogDataModel blog) =>
        {
            _logger.LogInformation("Blog Update Id => " + id);
            _logger.LogInformation("Blog Update Request Model => " + JsonSerializer.Serialize(blog));
            var item = await db.Blogs.FirstOrDefaultAsync(x => x.Blog_Id == id);
            if (item is null)
            {
                string Message = "No data found.";
                _logger.LogInformation("Blog Update Response Message => " + Message);
                return Results.NotFound(new
                {
                    IsSuccess = false,
                    Message = Message!,
                });
            }

            item.Blog_Title = blog.Blog_Title;
            item.Blog_Author = blog.Blog_Author;
            item.Blog_Content = blog.Blog_Content;

            var result = db.SaveChanges();
            BlogResponseModel model = new BlogResponseModel
            {
                IsSuccess = result > 0,
                Message = result > 0 ? "Update Successful." : "Updating Failed.",
                Data = item
            };

            _logger.LogInformation("Blog Update Response Model => " + JsonSerializer.Serialize(model));
            return Results.Ok(model);
        })
        .WithName("UpdateBlog")
        .WithOpenApi();

        app.MapPatch("/blog/{id}", ([FromServices] AppDbContext db, [FromServices] ILogger<Program> _logger, int id, BlogDataModel blog) =>
        {
            _logger.LogInformation("Blog Update Id => " + id);
            _logger.LogInformation("Blog Update Request Model => " +  JsonSerializer.Serialize(blog));
            var item = db.Blogs.FirstOrDefault(x => x.Blog_Id == id);

            if (item is null)
            {
                var response = new { IsSuccess = false, Message = "No data found." };
                _logger.LogInformation("Blog Update Response Model => " + JsonSerializer.Serialize(response));
                return Results.NotFound(response);
            }

            if (!string.IsNullOrEmpty(blog.Blog_Title))
            {
                item.Blog_Title = blog.Blog_Title;
            }
            if (!string.IsNullOrEmpty(blog.Blog_Author))
            {
                item.Blog_Author = blog.Blog_Author;
            }
            if (!string.IsNullOrEmpty(blog.Blog_Content))
            {
                item.Blog_Content = blog.Blog_Content;
            }

            var result = db.SaveChanges();
            BlogResponseModel model = new BlogResponseModel
            {
                IsSuccess = result > 0,
                Message = result > 0 ? "Updating Successful." : "Updating Failed.",
                Data = item
            };

            _logger.LogInformation("Blog Update Response Model => " + JsonSerializer.Serialize(model));
            return Results.Ok(model);
        })
        .WithName("PatchBlog")
        .WithOpenApi();

        app.MapDelete("/blog/{id}", ([FromServices] AppDbContext db,[FromServices] ILogger<Program> _logger, int id) =>
        {
            _logger.LogInformation("Blog Delete Id => " +  id);
            var item = db.Blogs.FirstOrDefault(x => x.Blog_Id == id);
            if (item is null)
            {
                var response = new { IsSuccess = false, Message = "No data found." };
                _logger.LogInformation("Blog Delete Response Model => " + JsonSerializer.Serialize(response));
                return Results.NotFound(response);
            }

            db.Blogs.Remove(item);
            var result = db.SaveChanges();
            BlogResponseModel model = new BlogResponseModel
            {
                IsSuccess = result > 0,
                Message = result > 0 ? "Deleting Successful." : "Deleting Failed."
            };
            _logger.LogInformation("Blog Delete Response Model => " + JsonSerializer.Serialize(model));
            return Results.Ok(model);
        })
        .WithName("DeleteBlog")
        .WithOpenApi();
    }
}