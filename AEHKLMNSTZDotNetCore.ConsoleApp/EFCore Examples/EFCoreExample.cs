using AEHKLMNSTZDotNetCore.ConsoleApp.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AEHKLMNSTZDotNetCore.ConsoleApp.EFCore_Examples
{
    public class EFCoreExample
    {

        private readonly AppDbContext _dbContext;

        public EFCoreExample()
        {
            _dbContext = new AppDbContext();
        }
        public void Run()
        {
            //Read();
            //Edit(2);
            //Edit(1000);
            //Create("test 8.50", "test 2", "test 3");
            //Update(2004, "test 8.53", "test 2", "test 3");
            //Delete(2004);
        }
        private void Read()
        {
            List<BlogDataModel> lst = _dbContext.Blogs.ToList();

            foreach (var item in lst)
            {
                Console.WriteLine(item.Blog_Id);
                Console.WriteLine(item.Blog_Title);
                Console.WriteLine(item.Blog_Author);
                Console.WriteLine(item.Blog_Content);
            }
        }
        private void Edit(int id)
        {
            
            BlogDataModel? item = _dbContext.Blogs.FirstOrDefault(x => x.Blog_Id == id);
            if (item is null)
            {
                Console.WriteLine("No data found.");
                return;
            }

            Console.WriteLine(item.Blog_Id);
            Console.WriteLine(item.Blog_Title);
            Console.WriteLine(item.Blog_Author);
            Console.WriteLine(item.Blog_Content);
        }
        private void Create(string title, string author, string content)
        {
            BlogDataModel blog = new BlogDataModel
            {
                Blog_Title = title,
                Blog_Author = author,
                Blog_Content = content
            };

            
            _dbContext.Blogs.Add(blog);
            int result = _dbContext.SaveChanges();
            string message = result > 0 ? "Saving Successful." : "Saving Failed.";
            Console.WriteLine(message);
            Console.WriteLine(blog.Blog_Id);
        }

        private void Update(int id, string title, string author, string content)
        {
            var blog = _dbContext.Blogs.FirstOrDefault(x => x.Blog_Id == id);
            if (blog is null)
            {
                Console.WriteLine("No data found.");
                return;
            }

            blog.Blog_Title = title;
            blog.Blog_Author = author;
            blog.Blog_Content = content;

            int result = _dbContext.SaveChanges();
            string message = result > 0 ? "Updating Successful." : "Updating Failed.";
            Console.WriteLine(message);
        }
        private void Delete(int id)
        {
            var blog = _dbContext.Blogs.FirstOrDefault(x => x.Blog_Id == id);
            if (blog is null)
            {
                Console.WriteLine("No data found.");
                return;
            }

            _dbContext.Blogs.Remove(blog);
            int result = _dbContext.SaveChanges();
            string message = result > 0 ? "Deleting Successful." : "Deleting Failed.";
            Console.WriteLine(message);
        }
    }
}
