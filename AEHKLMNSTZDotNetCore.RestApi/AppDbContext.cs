using AEHKLMNSTZDotNetCore.RestApi.Models;
using Microsoft.EntityFrameworkCore;

namespace AEHKLMNSTZDotNetCore.RestApi
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions options) : base(options)
        {
        }

        //private readonly SqlConnectionStringBuilder sqlConnectionStringBuilder = new SqlConnectionStringBuilder()
        //{
        //    DataSource = ".",
        //    InitialCatalog = "AHMTZDotNetCore",
        //    UserID = "sa",
        //    Password = "sa@123",
        //    TrustServerCertificate = true
        //};

        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    //if(optionsBuilder.IsConfigured == false)
        //    //{
        //    //}
        //    if (!optionsBuilder.IsConfigured)
        //    {
        //        optionsBuilder.UseSqlServer(sqlConnectionStringBuilder.ConnectionString);
        //    }
        //}

        public DbSet<BlogDataModel> Blogs { get; set; }
    }
}
