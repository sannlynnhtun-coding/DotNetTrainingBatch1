using AEHKLMNSTZDotNetCore.RestApi.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Text.Json;

namespace AEHKLMNSTZDotNetCore.RestApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BlogController : ControllerBase
    {
        private readonly AppDbContext _context;
        private readonly ILogger<BlogController> _logger;
        public BlogController(AppDbContext context, ILogger<BlogController> logger)
        {
            _context = context;
            _logger = logger;
        }

        [HttpGet]
        public IActionResult GetBlogs()
        {
            List<BlogDataModel> lst = _context.Blogs.ToList();
            BlogListResponseModel model = new BlogListResponseModel()
            {
                IsSuccess = true,
                Message = "Success",
                //Data = lst.Where(x => x.Blog_Title == "").OrderByDescending(x => x.Blog_Id).ToList()
                Data = lst
            };
            return Ok(model);
        }

        [HttpGet("{pageNo}/{pageSize}")]
        public IActionResult GetBlogs(int pageNo = 1, int pageSize = 10)
        {
            //pageNo = 1;
            //pageSize = 10;
            //int endRowNo = pageNo * pageSize;
            //int startRowNo = endRowNo - pageSize + 1;
            //// 1,  1 - 10 // 0
            //// 2, 11 - 20 // 10
            //// 3, 21 - 30 // 20, 21 - 30
            List<BlogDataModel> lst = _context
                .Blogs
                .Skip((pageNo - 1) * pageSize)
                .Take(pageSize)
                .ToList();
            BlogListResponseModel model = new BlogListResponseModel()
            {
                IsSuccess = true,
                Message = "Success",
                //Data = lst.Where(x => x.Blog_Title == "").OrderByDescending(x => x.Blog_Id).ToList()
                Data = lst
            };
            return Ok(model);
        }

        [HttpGet("{id}")]
        public IActionResult GetBlog(int id)
        {
            _logger.LogInformation("Get Blog with Id=" + id);

            BlogResponseModel model = new BlogResponseModel();

            BlogDataModel item = _context.Blogs.FirstOrDefault(x => x.Blog_Id == id);
            if (item is null)
            {
                model.IsSuccess = false;
                model.Message = "No data found.";
                return NotFound(model);
            }

            model.IsSuccess = true;
            model.Message = "Success";
            model.Data = item;
            _logger.LogInformation("Blog =>" + JsonSerializer.Serialize(model));
            return Ok(model);
        }

        [HttpPost]
        public IActionResult CreateBlog([FromBody] BlogDataModel blog)
        {
            _context.Blogs.Add(blog);
            var result = _context.SaveChanges();
            string message = result > 0 ? "Saving Successful." : "Saving Failed.";
            BlogResponseModel model = new BlogResponseModel()
            {
                IsSuccess = result > 0,
                Message = message,
            };
            return Ok(model);
        }

        [HttpPut("{id}")]
        public IActionResult UpdateBlog(int id, [FromBody] BlogDataModel blog)
        {
            BlogResponseModel model = new BlogResponseModel();

            BlogDataModel item = _context.Blogs.FirstOrDefault(x => x.Blog_Id == id);
            if (item == null)
            {
                model.IsSuccess = false;
                model.Message = "No data found.";
                return NotFound(model);
            }

            item.Blog_Title = blog.Blog_Title;
            item.Blog_Author = blog.Blog_Author;
            item.Blog_Content = blog.Blog_Content;

            var result = _context.SaveChanges();
            string message = result > 0 ? "Updating Successful." : "Updating Failed.";

            model = new BlogResponseModel()
            {
                IsSuccess = result > 0,
                Message = message,
            };
            return Ok(model);
        }

        //[HttpPatch("{id}")]
        //public IActionResult PatchBlog(int id, [FromBody] JsonPatchDocument<BlogDataModel> blogPatch)
        //{
        //    AppDbContext db = new AppDbContext();
        //    var blog = db.Blogs.FirstOrDefault(b => b.Blog_Id == id);

        //    BlogResponseModel data = new BlogResponseModel();
        //    if (blog is null)
        //    {
        //        data.IsSuccess = false;
        //        data.Message = "No data found.";
        //        return NotFound(data);
        //    }

        //    blogPatch.ApplyTo(blog);
        //    db.SaveChanges();
        //    data.IsSuccess = true;
        //    data.Message = "Success";
        //    data.Data = blog;

        //    return Ok(data);
        //}

        [HttpPatch("{id}")]
        public IActionResult PatchBlog(int id, [FromBody] BlogDataModel blog)
        {
            BlogResponseModel model = new BlogResponseModel();
            var item = _context.Blogs.FirstOrDefault(x => x.Blog_Id == id);

            if (item is null)
            {
                model.IsSuccess = false;
                model.Message = "No data found.";
                return NotFound(model);
            }

            if (!string.IsNullOrWhiteSpace(blog.Blog_Title))
            {
                item.Blog_Title = blog.Blog_Title;
            }
            if (!string.IsNullOrWhiteSpace(blog.Blog_Author))
            {
                item.Blog_Author = blog.Blog_Author;
            }
            if (!string.IsNullOrWhiteSpace(blog.Blog_Content))
            {
                item.Blog_Content = blog.Blog_Content;
            }

            var result = _context.SaveChanges();
            string message = result > 0 ? "Updating Successful." : "Updating Failed.";

            model = new BlogResponseModel()
            {
                IsSuccess = result > 0,
                Message = message,
            };

            return Ok(model);
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteBlog(int id)
        {
            var blog = _context.Blogs.FirstOrDefault(b => b.Blog_Id == id);

            BlogResponseModel data = new BlogResponseModel();
            if (blog is null)
            {
                data.IsSuccess = false;
                data.Message = "No data found.";
                return NotFound(data);
            }

            _context.Blogs.Remove(blog);
            _context.SaveChanges();
            data.IsSuccess = true;
            data.Message = "Success";
            return Ok(data);
        }
    }
}
