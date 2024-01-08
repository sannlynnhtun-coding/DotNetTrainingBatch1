using AEHKLMNSTZDotNetCore.MvcApp.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using RestSharp;

namespace AEHKLMNSTZDotNetCore.MvcApp.Controllers
{
    public class BlogRestClientController : Controller
    {
        private readonly RestClient _restClient;

        public BlogRestClientController(RestClient restClient)
        {
            _restClient = restClient;
        }

        public async Task<IActionResult> Index()
        {
            BlogListResponseModel model = new BlogListResponseModel();
            RestRequest request = new RestRequest("api/blog", Method.Get);
            var response = await _restClient.ExecuteAsync(request);
            if (response.IsSuccessStatusCode)
            {
                string jsonStr = response.Content!;
                model = JsonConvert.DeserializeObject<BlogListResponseModel>(jsonStr)!;
            }
            return View("~/Views/BlogRefit/Index.cshtml", model);
        }
    }
}
