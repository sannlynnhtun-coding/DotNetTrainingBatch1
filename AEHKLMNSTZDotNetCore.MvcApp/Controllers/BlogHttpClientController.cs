using AEHKLMNSTZDotNetCore.MvcApp.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace AEHKLMNSTZDotNetCore.MvcApp.Controllers
{
    public class BlogHttpClientController : Controller
    {
        private readonly HttpClient _httpClient;
        private readonly IConfiguration _configuration;

        public BlogHttpClientController(HttpClient httpClient, IConfiguration configuration)
        {
            _httpClient = httpClient;
            _configuration = configuration;
            //_httpClient.BaseAddress = new Uri(_configuration.GetSection("RestApiUrl").Value!);
        }

        public async Task<IActionResult> Index()
        {
            BlogListResponseModel model = new BlogListResponseModel();
            HttpResponseMessage response = await _httpClient.GetAsync("api/blog");
            if (response.IsSuccessStatusCode)
            {
                string jsonStr = await response.Content.ReadAsStringAsync();
                model = JsonConvert.DeserializeObject<BlogListResponseModel>(jsonStr)!;
            }
            return View("~/Views/BlogRefit/Index.cshtml", model);
        }
    }
}
