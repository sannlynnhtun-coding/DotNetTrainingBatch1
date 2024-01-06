using AEHKLMNSTZDotNetCore.ConsoleApp.Model;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace AEHKLMNSTZDotNetCore.ConsoleApp.HttpClientExamples
{
    public class HttpClientExample
    {
        public async Task Run()
        {
            // task - 5
            // task - 5
            // task - 5

            // task 3 - 5

            // get
            // post
            // put
            // patch
            // delete

            //await Read();
            //await Edit(2);
            //await Edit(6010);
            await Create("test 8.50", "test 2", "test 3");
            await Update(6010, "test", "test", "test");
            await Delete(6010);
        }

        private async Task Read()
        {
            HttpClient client = new HttpClient();
            HttpResponseMessage response = await client.GetAsync("https://localhost:7244/api/blog");
            if (response.IsSuccessStatusCode)
            {
                string jsonStr = await response.Content.ReadAsStringAsync();
                var model = JsonConvert.DeserializeObject<BlogListResponseModel>(jsonStr);
                foreach (var item in model!.Data)
                {
                    Console.WriteLine(item.Blog_Id);
                    Console.WriteLine(item.Blog_Title);
                    Console.WriteLine(item.Blog_Author);
                    Console.WriteLine(item.Blog_Content);
                }
            }
        }

        private async Task Edit(int id)
        {
            HttpClient client = new HttpClient();
            HttpResponseMessage response = await client.GetAsync($"https://localhost:7244/api/blog/{id}");
            if (response.IsSuccessStatusCode)
            {
                string jsonStr = await response.Content.ReadAsStringAsync();
                var model = JsonConvert.DeserializeObject<BlogResponseModel>(jsonStr);
                var item = model!.Data;
                Console.WriteLine(item.Blog_Id);
                Console.WriteLine(item.Blog_Title);
                Console.WriteLine(item.Blog_Author);
                Console.WriteLine(item.Blog_Content);
            }
            else
            {
                string jsonStr = await response.Content.ReadAsStringAsync();
                var model = JsonConvert.DeserializeObject<BlogResponseModel>(jsonStr);
                Console.WriteLine(model.Message);
            }
        }

        private async Task Create(string title, string author, string content)
        {
            BlogDataModel blog = new BlogDataModel
            {
                Blog_Title = title,
                Blog_Author = author,
                Blog_Content = content
            };
            string jsonBlog = JsonConvert.SerializeObject(blog);
            HttpContent httpContent = new StringContent(jsonBlog, Encoding.UTF8, Application.Json);

            HttpClient client = new HttpClient();
            HttpResponseMessage response = await client.PostAsync("https://localhost:7244/api/blog", httpContent);
            if (response.IsSuccessStatusCode)
            {
                string jsonStr = await response.Content.ReadAsStringAsync();
                var model = JsonConvert.DeserializeObject<BlogResponseModel>(jsonStr);
                await Console.Out.WriteLineAsync(model.Message);
            }
        }

        private async Task Update(int id, string title, string author, string content)
        {
            BlogDataModel blog = new BlogDataModel
            {
                Blog_Title = title,
                Blog_Author = author,
                Blog_Content = content
            };
            string jsonBlog = JsonConvert.SerializeObject(blog);
            HttpContent httpContent = new StringContent(jsonBlog, Encoding.UTF8, Application.Json);

            HttpClient client = new HttpClient();
            HttpResponseMessage response = await client.PutAsync($"https://localhost:7244/api/blog/{id}", httpContent);
            if (response.IsSuccessStatusCode)
            {
                string jsonStr = await response.Content.ReadAsStringAsync();
                var model = JsonConvert.DeserializeObject<BlogResponseModel>(jsonStr);
                await Console.Out.WriteLineAsync(model.Message);
            }
            else
            {
                string jsonStr = await response.Content.ReadAsStringAsync();
                var model = JsonConvert.DeserializeObject<BlogResponseModel>(jsonStr);
                Console.WriteLine(model.Message);
            }
        }

        private async Task Delete(int id)
        {
            HttpClient client = new HttpClient();
            HttpResponseMessage response = await client.DeleteAsync($"https://localhost:7244/api/blog/{id}");
            if (response.IsSuccessStatusCode)
            {
                string jsonStr = await response.Content.ReadAsStringAsync();
                var model = JsonConvert.DeserializeObject<BlogResponseModel>(jsonStr);
                Console.WriteLine(model.Message);
            }
            else
            {
                string jsonStr = await response.Content.ReadAsStringAsync();
                var model = JsonConvert.DeserializeObject<BlogResponseModel>(jsonStr);
                Console.WriteLine(model.Message);
            }
        }

    }
}
