using Microsoft.AspNetCore.Mvc;

namespace AEHKLMNSTZDotNetCore.MvcApp.Controllers
{
    public class BlogController : Controller
    {
        [ActionName("Index")]
        public IActionResult BlogIndex()
        {
            return View("BlogIndex");
        }
    }
}
