using Microsoft.AspNetCore.Mvc;

namespace AEHKLMNSTZDotNetCore.MvcApp.Controllers
{
    public class UserController : Controller
    {
        [ActionName("Index")]
        public IActionResult UserIndex()
        {
            return View("UserIndex");
        }
    }
}
