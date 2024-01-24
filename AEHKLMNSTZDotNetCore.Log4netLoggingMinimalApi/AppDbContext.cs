using AEHKLMNSTZDotNetCore.Log4netLoggingMinimalApi.Models;
using Microsoft.EntityFrameworkCore;

namespace AEHKLMNSTZDotNetCore.Log4netLoggingMinimalApi
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<BlogDataModel> Blogs { get; set; }
    }
}
