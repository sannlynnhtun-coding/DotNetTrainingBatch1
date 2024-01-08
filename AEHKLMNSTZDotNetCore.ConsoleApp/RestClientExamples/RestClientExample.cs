using AEHKLMNSTZDotNetCore.ConsoleApp.Model;
using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AEHKLMNSTZDotNetCore.ConsoleApp.RestClientExamples
{
    internal class RestClientExample
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

            await Read();
            //await Edit(2);
            //await Edit(6010);
            await Create("test 8.50", "test 2", "test 3");
            await Update(6010, "test", "test", "test");
            await Delete(6010);
        }

        private async Task Read()
        {
            RestRequest request = new RestRequest("https://localhost:7244/api/blog", Method.Get);
            RestClient client = new RestClient();
            //await client.GetAsync(request);
            var response = await client.ExecuteAsync(request);
            if (response.IsSuccessStatusCode)
            {
                string jsonStr = response.Content!;
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
            RestRequest request = new RestRequest($"https://localhost:7244/api/blog/{id}", Method.Get);
            RestClient client = new RestClient();
            var response = await client.ExecuteAsync(request);
            if (response.IsSuccessStatusCode)
            {
                string jsonStr = response.Content!;
                var model = JsonConvert.DeserializeObject<BlogResponseModel>(jsonStr);
                var item = model!.Data;
                Console.WriteLine(item.Blog_Id);
                Console.WriteLine(item.Blog_Title);
                Console.WriteLine(item.Blog_Author);
                Console.WriteLine(item.Blog_Content);
            }
            else
            {
                string jsonStr = response.Content!;
                var model = JsonConvert.DeserializeObject<BlogResponseModel>(jsonStr);
                Console.WriteLine(model!.Message);
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
            RestRequest request = new RestRequest("https://localhost:7244/api/blog", Method.Post);
            request.AddJsonBody(blog);
            RestClient client = new RestClient();
            var response = await client.ExecuteAsync(request);
            if (response.IsSuccessStatusCode)
            {
                string jsonStr = response.Content!;
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
            RestRequest request = new RestRequest($"https://localhost:7244/api/blog/{id}", Method.Put);
            request.AddJsonBody(blog);
            RestClient client = new RestClient();
            var response = await client.ExecuteAsync(request);
            if (response.IsSuccessStatusCode)
            {
                string jsonStr = response.Content!;
                var model = JsonConvert.DeserializeObject<BlogResponseModel>(jsonStr);
                await Console.Out.WriteLineAsync(model!.Message);
            }
            else
            {
                string jsonStr = response.Content!;
                var model = JsonConvert.DeserializeObject<BlogResponseModel>(jsonStr);
                Console.WriteLine(model!.Message);
            }
        }

        private async Task Delete(int id)
        {
            RestRequest request = new RestRequest($"https://localhost:7244/api/blog/{id}", Method.Delete);
            RestClient client = new RestClient();
            var response = await client.ExecuteAsync(request);
            if (response.IsSuccessStatusCode)
            {
                string jsonStr = response.Content!;
                var model = JsonConvert.DeserializeObject<BlogResponseModel>(jsonStr);
                Console.WriteLine(model!.Message);
            }
            else
            {
                string jsonStr = response.Content!;
                var model = JsonConvert.DeserializeObject<BlogResponseModel>(jsonStr);
                Console.WriteLine(model!.Message);
            }
        }
    }
}
