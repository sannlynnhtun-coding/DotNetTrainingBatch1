using AEHKLMNSTZDotNetCore.ConsoleApp.Model;
using Refit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AEHKLMNSTZDotNetCore.ConsoleApp.RefitExamples
{
    public class RefitExample
    {
        private readonly IBlogApi blogApi = RestService.For<IBlogApi>("https://localhost:7244");

        public async Task Run()
        {
            await Read();
        }

        private async Task Read()
        {
            var model = await blogApi.GetBlogs();
            foreach (var item in model!.Data)
            {
                Console.WriteLine(item.Blog_Id);
                Console.WriteLine(item.Blog_Title);
                Console.WriteLine(item.Blog_Author);
                Console.WriteLine(item.Blog_Content);
            }
        }

        private async Task Edit(int id)
        {
            var model = await blogApi.GetBlog(id);
            var item = model!.Data;
            Console.WriteLine(item.Blog_Id);
            Console.WriteLine(item.Blog_Title);
            Console.WriteLine(item.Blog_Author);
            Console.WriteLine(item.Blog_Content);
        }

        private async Task Create(string title, string author, string content)
        {
            BlogDataModel blog = new BlogDataModel
            {
                Blog_Title = title,
                Blog_Author = author,
                Blog_Content = content
            };
            var model = await blogApi.CreateBlog(blog);
            await Console.Out.WriteLineAsync(model.Message);
        }
    }
}
