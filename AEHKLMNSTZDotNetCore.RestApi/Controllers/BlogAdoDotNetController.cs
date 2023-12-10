using AEHKLMNSTZDotNetCore.RestApi.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using System.Data;

namespace AEHKLMNSTZDotNetCore.RestApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BlogAdoDotNetController : ControllerBase
    {
        private readonly SqlConnectionStringBuilder _sqlConnectionStringBuilder;

        public BlogAdoDotNetController(IConfiguration configuration)
        {
            string connectionString = configuration.GetConnectionString("DbConnection");
            _sqlConnectionStringBuilder = new SqlConnectionStringBuilder(connectionString);
        }

        [HttpGet]
        public IActionResult GetBlogs()
        {
            string query = "select * from tbl_blog";

            SqlConnection connection = new SqlConnection(_sqlConnectionStringBuilder.ConnectionString);
            connection.Open();

            SqlCommand cmd = new SqlCommand(query, connection);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);

            connection.Close();

            List<BlogDataModel> lst = new List<BlogDataModel>();
            foreach (DataRow dr in dt.Rows)
            {
                BlogDataModel item = new BlogDataModel
                {
                    Blog_Id = Convert.ToInt32(dr["Blog_Id"]),
                    Blog_Title = dr["Blog_Title"].ToString(),
                    Blog_Author = dr["Blog_Author"].ToString(),
                    Blog_Content = dr["Blog_Content"].ToString(),
                };
                lst.Add(item);
            }
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
           ,@Blog_Content)
            ";

            SqlConnection connection = new SqlConnection(_sqlConnectionStringBuilder.ConnectionString);
            connection.Open();

            SqlCommand cmd = new SqlCommand(query, connection);
            cmd.Parameters.AddWithValue("@Blog_Title", blog.Blog_Title);
            cmd.Parameters.AddWithValue("@Blog_Author", blog.Blog_Author);
            cmd.Parameters.AddWithValue("@Blog_Content", blog.Blog_Content);
            int result = cmd.ExecuteNonQuery();
            string message = result > 0 ? "Saving Successful." : "Saving Failed.";

            connection.Close();

            BlogResponseModel model = new BlogResponseModel()
            {
                IsSuccess = result > 0,
                Message = message,
            };
            return Ok(model);
        }

        [HttpGet("{id}")]
        public IActionResult Edit(int id)
        {
            string query = "select * from tbl_blog where Blog_Id = @BlogId;";

            SqlConnection connection = new SqlConnection(_sqlConnectionStringBuilder.ConnectionString);
            connection.Open();

            SqlCommand cmd = new SqlCommand(query, connection);
            cmd.Parameters.AddWithValue("@BlogId", id);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);

            connection.Close();

            BlogResponseModel responseModel = new BlogResponseModel();
            if (dt.Rows.Count == 0)
            {
                responseModel.IsSuccess = false;
                responseModel.Message = "No Data Found!!";
                return NotFound(responseModel);
            }

            DataRow dr = dt.Rows[0];
            BlogDataModel dataModel = new BlogDataModel()
            {
                Blog_Id = Convert.ToInt32(dr["Blog_Id"]),
                Blog_Title = dr["Blog_Title"].ToString(),
                Blog_Author = dr["Blog_Author"].ToString(),
                Blog_Content = dr["Blog_Content"].ToString()
            };

            responseModel.IsSuccess = true;
            responseModel.Message = "Success";
            responseModel.Data = dataModel;
            return Ok(responseModel);
        }

        [HttpPut("{id}")]
        public IActionResult Update(int id, [FromBody] BlogDataModel blog)
        {
            string query = @"UPDATE [dbo].[Tbl_Blog]
                             SET
                             [Blog_Title] = @Blog_Title,
                             [Blog_Author] = @Blog_Author,
                             [Blog_Content] = @Blog_Content
                             WHERE
                             [Blog_Id] = @Blog_Id";

            SqlConnection connection = new SqlConnection(_sqlConnectionStringBuilder.ConnectionString);
            connection.Open();

            SqlCommand cmd = new SqlCommand(query, connection);

            cmd.Parameters.AddWithValue("@Blog_Id", id);
            cmd.Parameters.AddWithValue("@Blog_Title", blog.Blog_Title);
            cmd.Parameters.AddWithValue("@Blog_Author", blog.Blog_Author);
            cmd.Parameters.AddWithValue("@Blog_Content", blog.Blog_Content);

            int result = cmd.ExecuteNonQuery();

            string message = result > 0 ? "Update Successful !!" : "Error While Update !!";

            connection.Close();

            BlogResponseModel responseModel = new BlogResponseModel();
            responseModel.IsSuccess = result > 0;
            responseModel.Message = message;

            if (result < 0)
            {
                return NotFound(responseModel);
            }
            blog.Blog_Id = id;
            responseModel.Data = blog;
            return Ok(responseModel);
        }

        [HttpPatch("{id}")]
        public IActionResult Patch(int id, [FromBody] BlogDataModel blog)
        {
            string query = "SELECT * FROM [Tbl_Blog] WHERE [Blog_Id] = @Blog_Id";

            SqlConnection connection = new SqlConnection(_sqlConnectionStringBuilder.ConnectionString);
            connection.Open();

            SqlCommand cmd = new SqlCommand(query, connection);
            cmd.Parameters.AddWithValue("@Blog_Id", id);

            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);

            BlogResponseModel responseModle = new BlogResponseModel();

            if (dt.Rows.Count == 0)
            {
                responseModle.IsSuccess = false;
                responseModle.Message = "No Data Found!!";
                return NotFound(responseModle);
            }

            DataRow dr = dt.Rows[0];
            BlogDataModel dataModel = new BlogDataModel()
            {
                Blog_Id = Convert.ToInt32(dr["Blog_Id"]),
                Blog_Title = dr["Blog_Title"].ToString(),
                Blog_Author = dr["Blog_Author"].ToString(),
                Blog_Content = dr["Blog_Content"].ToString()
            };

            string query1 = @"UPDATE [dbo].[Tbl_Blog]
                             SET
                             [Blog_Title] = @Blog_Title,
                             [Blog_Author] = @Blog_Author,
                             [Blog_Content] = @Blog_Content
                             WHERE
                             [Blog_Id] = @Blog_Id";

            SqlCommand cmd1 = new SqlCommand(query1, connection);

            cmd1.Parameters.AddWithValue("@Blog_Id", id);

            if (!string.IsNullOrWhiteSpace(blog.Blog_Title))
            {
                cmd1.Parameters.AddWithValue("@Blog_Title", blog.Blog_Title);
            }
            else
            {
                cmd1.Parameters.AddWithValue("@Blog_Title", dataModel.Blog_Title);
            }

            if (!string.IsNullOrWhiteSpace(blog.Blog_Author))
            {
                cmd1.Parameters.AddWithValue("@Blog_Author", blog.Blog_Author);
            }
            else
            {
                cmd1.Parameters.AddWithValue("@Blog_Author", dataModel.Blog_Author);
            }

            if (!string.IsNullOrWhiteSpace(blog.Blog_Content))
            {
                cmd1.Parameters.AddWithValue("@Blog_Content", blog.Blog_Content);
            }
            else
            {
                cmd1.Parameters.AddWithValue("@Blog_Content", dataModel.Blog_Content);
            }

            int result = cmd1.ExecuteNonQuery();

            string message = result > 0 ? "Updating Successful." : "Updating Failed.";

            responseModle.IsSuccess = result > 0;
            responseModle.Message = message;
            return Ok(responseModle);
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            string query = @"DELETE FROM [dbo].[Tbl_Blog] WHERE [BLog_Id] = @Blog_Id";

            SqlConnection connection = new SqlConnection(_sqlConnectionStringBuilder.ConnectionString);
            connection.Open();
            SqlCommand cmd = new SqlCommand(query, connection);
            cmd.Parameters.AddWithValue("@BLog_Id", id);

            int result = cmd.ExecuteNonQuery();

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
