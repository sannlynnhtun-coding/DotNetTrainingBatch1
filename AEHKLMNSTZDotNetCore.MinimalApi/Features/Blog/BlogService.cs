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

		app.MapPut("/blog/{id}", async ([FromServices] AppDbContext db, int id, BlogDataModel blog) =>
		{
			var item = await db.Blogs.FirstOrDefaultAsync(x => x.Blog_Id == id);
			if (item is null)
			{
				return Results.NotFound(new
				{
					IsSuccess = false,
					Message = "No data found."
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
			return Results.Ok(model);
		})
		.WithName("UpdateBlog")
		.WithOpenApi();

		app.MapPatch("/blog/{id}", ([FromServices] AppDbContext db, int id, BlogDataModel blog) =>
		{
			var item = db.Blogs.FirstOrDefault(x => x.Blog_Id == id);

			if (item is null)
			{
				var response = new { IsSuccess = false, Message = "No data found." };
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
			return Results.Ok(model);
		})
		.WithName("PatchBlog")
		.WithOpenApi();

		app.MapDelete("/blog/{id}", ([FromServices] AppDbContext db, int id) =>
		{
			var item = db.Blogs.FirstOrDefault(x => x.Blog_Id == id);
			if (item is null)
			{
				var response = new { IsSuccess = false, Message = "No data found." };
				return Results.NotFound(response);
			}

			db.Blogs.Remove(item);
			var result = db.SaveChanges();
			BlogResponseModel model = new BlogResponseModel
			{
				IsSuccess = result > 0,
				Message = result > 0 ? "Deleting Successful." : "Deleting Failed."
			};
			return Results.Ok(model);
		})
		.WithName("DeleteBlog")
		.WithOpenApi();
	}
}