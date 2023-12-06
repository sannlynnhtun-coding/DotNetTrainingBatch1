using AEHKLMNSTZDotNetCore.MvcApp.EFDbContext;
using AEHKLMNSTZDotNetCore.MvcApp.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion.Internal;

namespace AEHKLMNSTZDotNetCore.MvcApp.Controllers
{
    public class BlogController : Controller
    {
        private readonly AppDbContext _context;

        public BlogController(AppDbContext context)
        {
            _context = context;
        }

        // Get / List
        [ActionName("Index")]
        public IActionResult BlogIndex()
        {
            List<BlogDataModel> lst = _context.Blogs.ToList();
            //ViewData["Title"] = "dfasdfsafsd";
            return View("BlogIndex", lst);
            //return Redirect("/blog/create");
        }

        [ActionName("Create")]
        public IActionResult BlogCreate()
        {
            return View("BlogCreate");
        }

        [HttpPost]
        [ActionName("Save")]
        public async Task<IActionResult> BlogSave(BlogDataModel reqModel)
        {
            await _context.Blogs.AddAsync(reqModel);
            var result = await _context.SaveChangesAsync();
            string message = result > 0 ? "Saving Successful." : "Saving Failed.";
            TempData["Message"] = message;
            TempData["IsSuccess"] = result > 0;
            // ViewBag
            // ViewData
            // TempData
            // Session

            //return View("BlogCreate");
            return Redirect("/blog");
        }
    }
}
