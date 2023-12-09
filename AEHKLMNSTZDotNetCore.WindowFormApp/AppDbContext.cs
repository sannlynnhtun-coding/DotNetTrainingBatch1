using AEHKLMNSTZDotNetCore.WindowFormApp.Models;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AEHKLMNSTZDotNetCore.WindowFormApp
{
    internal class AppDbContext : DbContext
    {
        public AppDbContext(string nameOrConnectionString) : base(nameOrConnectionString)
        {
        }

        public DbSet<BlogDataModel> Blogs { get; set; }
    }
}
