using AEHKLMNSTZDotNetCore.ConsoleApp.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AEHKLMNSTZDotNetCore.ConsoleApp.EFCore_Examples
{
    public class AppDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                var sqlConnectionStringBuilder = new SqlConnectionStringBuilder
                {
                    DataSource = ".", // server name
                    InitialCatalog = "ALTDotNetCore",
                    UserID = "sa",
                    Password = "sa@123",
                    TrustServerCertificate = true
                };
                optionsBuilder.UseSqlServer(sqlConnectionStringBuilder.ConnectionString);
            }
        }

        public DbSet<BlogDataModel> Blogs { get; set; }
    }
}
