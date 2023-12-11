using AEHKLMNSTZDotNetCore.MvcApp.EFDbContext;
using AEHKLMNSTZDotNetCore.MvcApp.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
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

        // blog/edit?blogid=1
        // blog/edit/1
        [ActionName("Edit")]
        public async Task<IActionResult> BlogEdit(int id)
        {
            if(!await _context.Blogs.AsNoTracking().AnyAsync(x=> x.Blog_Id == id))
            {
                TempData["Message"] = "No data found.";
                TempData["IsSuccess"] = false;
                return Redirect("/blog");
            }

            var blog = await _context.Blogs.AsNoTracking().FirstOrDefaultAsync(x => x.Blog_Id == id);
            if (blog is null)
            {
                TempData["Message"] = "No data found.";
                TempData["IsSuccess"] = false;
                return Redirect("/blog");
            }

            return View("BlogEdit", blog);
        }

        [HttpPost]
        [ActionName("Update")]
        public async Task<IActionResult> BlogUpdate(int id, BlogDataModel reqModel)
        {
            if (!await _context.Blogs.AsNoTracking().AnyAsync(x => x.Blog_Id == id))
            {
                TempData["Message"] = "No data found.";
                TempData["IsSuccess"] = false;
                return Redirect("/blog");
            }

            var blog = await _context.Blogs.FirstOrDefaultAsync(x => x.Blog_Id == id);
            if (blog is null)
            {
                TempData["Message"] = "No data found.";
                TempData["IsSuccess"] = false;
                return Redirect("/blog");
            }

            blog.Blog_Title = reqModel.Blog_Title;
            blog.Blog_Author = reqModel.Blog_Author;
            blog.Blog_Content = reqModel.Blog_Content;

            int result = _context.SaveChanges();
            string message = result > 0 ? "Updating Successful." : "Updating Failed.";
            TempData["Message"] = message;
            TempData["IsSuccess"] = result > 0;

            return Redirect("/blog");
        }

        [ActionName("Delete")]
        public async Task<IActionResult> BlogDelete(int id)
        {
            if (!await _context.Blogs.AsNoTracking().AnyAsync(x => x.Blog_Id == id))
            {
                TempData["Message"] = "No data found.";
                TempData["IsSuccess"] = false;
                return Redirect("/blog");
            }

            var blog = await _context.Blogs.AsNoTracking().FirstOrDefaultAsync(x => x.Blog_Id == id);
            if (blog is null)
            {
                TempData["Message"] = "No data found.";
                TempData["IsSuccess"] = false;
                return Redirect("/blog");
            }

            _context.Remove(blog);
            int result = _context.SaveChanges();
            string message = result > 0 ? "Deleting Successful." : "Deleting Failed.";
            TempData["Message"] = message;
            TempData["IsSuccess"] = result > 0;

            return Redirect("/blog");
        }
    }
}
