using AEHKLMNSTZDotNetCore.MinimalApi;
using AEHKLMNSTZDotNetCore.MinimalApi.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace AEHKLMNSTZDotNetCore.MinimalApi.Features.Blog;

public static class BlogService
{
    public static void AddBlogService(this IEndpointRouteBuilder app)
    {
        app.MapGet("/blog/{pageNo}/{pageSize}", async ([FromServices] AppDbContext db, int pageNo, int pageSize) =>
        {
            return await db.Blogs
                .AsNoTracking()
                .Skip((pageNo - 1) * pageSize)
                .Take(pageSize)
                .ToListAsync();
        })
        .WithName("GetBlogs")
        .WithOpenApi();

        app.MapPost("/blog", async ([FromServices] AppDbContext db, BlogDataModel blog) =>
        {
            await db.Blogs.AddAsync(blog);
            int result = await db.SaveChangesAsync();

            string message = result > 0 ? "Saving Successful." : "Saving Failed.";
            return Results.Ok(new BlogResponseModel
            {
                Data = blog,
                IsSuccess = result > 0,
                Message = message
            });
        })
       .WithName("CreateBlog")
       .WithOpenApi();
    }
}