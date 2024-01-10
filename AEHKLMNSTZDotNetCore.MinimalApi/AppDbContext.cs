using AEHKLMNSTZDotNetCore.MinimalApi.Models;
using Microsoft.EntityFrameworkCore;

namespace AEHKLMNSTZDotNetCore.MinimalApi
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<BlogDataModel> Blogs { get; set; }
    }
}
