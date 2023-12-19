using AEHKLMNSTZDotNetCore.MvcApp.EFDbContext;
using AEHKLMNSTZDotNetCore.MvcApp.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace AEHKLMNSTZDotNetCore.MvcApp.Controllers
{
    public class BlogAjaxController : Controller
    {
        private readonly AppDbContext _context;

        public BlogAjaxController(AppDbContext context)
        {
            _context = context;
        }

        [ActionName("List")]
        public async Task<IActionResult> BlogList(int pageNo = 1, int pageSize = 10)
        {
            BlogDataResponseModel model = new BlogDataResponseModel();
            List<BlogDataModel> lst = _context.Blogs.AsNoTracking()
                .Skip((pageNo - 1) * pageSize)
            .Take(pageSize)
                .ToList();

            int rowCount = await _context.Blogs.CountAsync();
            int pageCount = rowCount / pageSize;
            if (rowCount % pageSize > 0)
                pageCount++;

            model.Blogs = lst;
            model.PageSetting = new PageSettingModel(pageNo, pageSize, pageCount, "/blogajax/list");

            return View("BlogList", model);
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

            MessageModel model = new MessageModel(result > 0, message);
            return Json(model);
        }

        [HttpGet]
        [ActionName("Edit")]
        public async Task<IActionResult> BlogEdit(int id)
        {
            var blog = await _context.Blogs.AsNoTracking().FirstOrDefaultAsync(x => x.Blog_Id == id);
            if (blog is null)
            {
                TempData["Message"] = "No data found.";
                TempData["IsSuccess"] = false;
                return Redirect("/blogajax/list");
            }
            return View("BlogEdit", blog);
        }

        [HttpPost]
        [ActionName("Update")]
        public async Task<IActionResult> BlogUpdate(int id, BlogDataModel reqModel)
        {
            var blog = await _context.Blogs.FirstOrDefaultAsync(x => x.Blog_Id == id);

            if (blog != null)
            {
                blog.Blog_Title = reqModel.Blog_Title;
                blog.Blog_Author = reqModel.Blog_Author;
                blog.Blog_Content = reqModel.Blog_Content;

                var result = await _context.SaveChangesAsync();

                string message = result > 0 ? "Update Successful." : "Update Failed.";
                TempData["Message"] = message;
                TempData["IsSuccess"] = result > 0;

                MessageModel model = new MessageModel(result > 0, message);
                return Json(model);
            }

            return Json(new MessageModel(false, "No Data Found to Update"));
        }

        [HttpPost]
        [ActionName("Delete")]
        public async Task<IActionResult> BlogDelete(BlogDataModel reqModel)
        {
            BlogDataModel? blog = await _context.Blogs.FirstOrDefaultAsync(x => x.Blog_Id == reqModel.Blog_Id);

            if (blog is null)
            {
				return Json(new MessageModel(false, "No data found."));
			}

            _context.Blogs.Remove(blog);
			var result = await _context.SaveChangesAsync();
			string message = result > 0 ? "Your blog has been deleted." : "Deleting Failed.";
			TempData["Message"] = message;
			TempData["IsSuccess"] = result > 0;

			MessageModel model = new MessageModel(result > 0, message);
			return Json(model);
		}
    }
}
