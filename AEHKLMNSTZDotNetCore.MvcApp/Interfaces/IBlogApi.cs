using Refit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AEHKLMNSTZDotNetCore.MvcApp.Models;

namespace AEHKLMNSTZDotNetCore.MvcApp.Interfaces
{
    public interface IBlogApi
    {
        [Get("/api/blog")]
        Task<BlogListResponseModel> GetBlogs();

        [Get("/api/blog/{id}")]
        Task<BlogResponseModel> GetBlog(int id);

        [Post("/api/blog")]
        Task<BlogResponseModel> CreateBlog(BlogDataModel blog);

        [Put("/api/blog/{id}")]
        Task<BlogResponseModel> UpdateBlog(int id, BlogDataModel blog);

        [Delete("/api/blog/{id}")]
        Task<BlogResponseModel> DeleteBlog(int id);
    }
}
