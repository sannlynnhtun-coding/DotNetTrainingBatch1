using Microsoft.AspNetCore.Mvc;

namespace AEHKLMNSTZDotNetCore.MvcApp.Controllers
{
    public class BlogAjaxController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
