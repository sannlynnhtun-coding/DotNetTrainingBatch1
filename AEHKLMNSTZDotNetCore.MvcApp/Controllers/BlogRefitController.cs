using AEHKLMNSTZDotNetCore.MvcApp.Interfaces;
using AEHKLMNSTZDotNetCore.MvcApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace AEHKLMNSTZDotNetCore.MvcApp.Controllers
{
	public class BlogRefitController : Controller
	{
		private readonly IBlogApi _blogApi;

		public BlogRefitController(IBlogApi blogApi)
		{
			_blogApi = blogApi;
		}
		[HttpGet]
		[ActionName("Index")]
		public async Task<IActionResult> Index()
		{
			var model = await _blogApi.GetBlogs();
			return View(model);
		}

		[ActionName("Create")]
		public IActionResult BlogRefitCreate()
		{
			return View("BlogRefitCreate");
		}

		[HttpPost]
		[ActionName("Save")]
		public async Task<IActionResult> BlogSave(BlogDataModel reqModel)
		{
			var model = await _blogApi.CreateBlog(reqModel);
			return Redirect("/blogrefit");
		}

		[ActionName("Edit")]
		public async Task<IActionResult> BlogRefitEdit(int id)
		{
			var model = await _blogApi.GetBlog(id);
			return View("BlogRefitEdit", model);
		}

		[HttpPost]
		[ActionName("Update")]
		public async Task<IActionResult> BlogUpdate(int id, BlogDataModel reqModel)
		{
			var model = await _blogApi.UpdateBlog(id, reqModel);
			return Redirect("/blogrefit");
		}

		[ActionName("Delete")]
		public async Task<IActionResult> BlogDelete(int id)
		{
			var model = await _blogApi.DeleteBlog(id);
			return Redirect("/blogrefit");
		}
	}
}
