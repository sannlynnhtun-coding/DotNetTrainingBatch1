using AEHKLMNSTZDotNetCore.RestApi.Models;
using Microsoft.EntityFrameworkCore;

namespace AEHKLMNSTZDotNetCore.RestApi
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<BlogDataModel> Blogs { get; set; }
    }
}
