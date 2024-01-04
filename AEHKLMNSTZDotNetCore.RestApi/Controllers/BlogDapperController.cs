using AEHKLMNSTZDotNetCore.RestApi.Models;
using Dapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using System.Data;

namespace AEHKLMNSTZDotNetCore.RestApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BlogDapperController : ControllerBase
    {
        private readonly SqlConnectionStringBuilder _sqlConnectionStringBuilder;

        public BlogDapperController(IConfiguration configuration)
        {
            string connectionString = configuration.GetConnectionString("DbConnection");
            string connectionString2 = configuration.GetSection("SqlDbConnection").Value;
            string connectionString3 = configuration.GetSection("MyDbConnections:MyDb:DbConnection").Value;
            _sqlConnectionStringBuilder = new SqlConnectionStringBuilder(connectionString);
        }

        [HttpGet]
        public IActionResult GetBlogs()
        {
            string query = "select * from tbl_blog order by Blog_Id desc";
            using IDbConnection db = new SqlConnection(_sqlConnectionStringBuilder.ConnectionString);

            List<BlogDataModel> lst = db.Query<BlogDataModel>(query).ToList();
            BlogListResponseModel model = new BlogListResponseModel()
            {
                IsSuccess = true,
                Message = "Success",
                Data = lst
            };

            return Ok(model);
        }

        [HttpPost]
        public IActionResult CreateBlog([FromBody] BlogDataModel blog)
        {
            string query = $@"INSERT INTO [dbo].[Tbl_Blog]
           ([Blog_Title]
           ,[Blog_Author]
           ,[Blog_Content])
     VALUES
           (@Blog_Title
           ,@Blog_Author
           ,@Blog_Content)";

            using IDbConnection db = new SqlConnection(_sqlConnectionStringBuilder.ConnectionString);
            var result = db.Execute(query, blog);
            string message = result > 0 ? "Saving Successful." : "Saving Failed.";

            BlogResponseModel model = new BlogResponseModel()
            {
                IsSuccess = result > 0,
                Message = message,
            };
            return Ok(model);
        }

        [HttpGet("{id}")]
        public IActionResult EditBlog(int id)
        {
            string query = "SELECT * FROM [Tbl_Blog] WHERE [Blog_Id] = @Blog_Id";

            BlogDataModel dataModel = new BlogDataModel()
            {
                Blog_Id = id,
            };

            using IDbConnection db = new SqlConnection(_sqlConnectionStringBuilder.ConnectionString);
            BlogDataModel item = db.Query<BlogDataModel>(query, dataModel).FirstOrDefault();

            BlogResponseModel model = new BlogResponseModel();
            if (item == null)
            {
                model.IsSuccess = false;
                model.Message = "No Data Found!!";
                return NotFound(model);
            }

            model.IsSuccess = true;
            model.Message = "Success";
            model.Data = item;
            return Ok(model);
        }

        [HttpPut("{id}")]
        public IActionResult UpdateBlog(int id, [FromBody] BlogDataModel blog)
        {
            string query = @"UPDATE [dbo].[Tbl_Blog]
                             SET
                             [Blog_Title] = @Blog_Title,
                             [Blog_Author] = @Blog_Author,
                             [Blog_Content] = @Blog_Content
                             WHERE
                             [Blog_Id] = @Blog_Id";

            using IDbConnection db = new SqlConnection(_sqlConnectionStringBuilder.ConnectionString);
            blog.Blog_Id = id;
            var result = db.Execute(query, blog);

            string message = result > 0 ? "Update Successful !!" : "Error While Update !!";

            BlogResponseModel model = new BlogResponseModel();
            model.IsSuccess = result > 0;
            model.Message = message;

            if (result < 0)
            {
                return NotFound(model);
            }
            model.Data = blog;
            return Ok(model);
        }

        [HttpPatch("{id}")]
        public IActionResult PatchBlog(int id, [FromBody] BlogDataModel blog)
        {
            string query = "SELECT * FROM [Tbl_Blog] WHERE [Blog_Id] = @Blog_Id";
            blog.Blog_Id = id;
            using IDbConnection db = new SqlConnection(_sqlConnectionStringBuilder.ConnectionString);
            var item = db.Query<BlogDataModel>(query, blog).FirstOrDefault();

            BlogResponseModel responseModle = new BlogResponseModel();

            if (item == null)
            {
                responseModle.IsSuccess = false;
                responseModle.Message = "No Data Found!!";
                return NotFound(responseModle);
            }

            string query1 = @"UPDATE [dbo].[Tbl_Blog]
                             SET
                             [Blog_Title] = @Blog_Title,
                             [Blog_Author] = @Blog_Author,
                             [Blog_Content] = @Blog_Content
                             WHERE
                             [Blog_Id] = @Blog_Id";

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

            var result = db.Execute(query1, item);

            string message = result > 0 ? "Updating Successful." : "Updating Failed.";

            responseModle.IsSuccess = result > 0;
            responseModle.Message = message;
            return Ok(responseModle);
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteBlog(int id)
        {
            string query = @"DELETE FROM [dbo].[Tbl_Blog] WHERE [Blog_Id] = @Blog_Id";

            BlogDataModel item = new BlogDataModel()
            {
                Blog_Id = id,
            };

            using IDbConnection db = new SqlConnection(_sqlConnectionStringBuilder.ConnectionString);
            var result = db.Execute(query, item);

            string message = result > 0 ? "Delete Successful !!" : "Error While Delete !!";

            BlogResponseModel model = new BlogResponseModel();
            if (result > 0)
            {
                model.IsSuccess = result > 0;
                model.Message = message;
                return Ok(model);
            }
            model.IsSuccess = result > 0;
            model.Message = message;
            return Ok(model);
        }
    }
}
