using AEHKLMNSTZDotNetCore.ConsoleApp.Model;
using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AEHKLMNSTZDotNetCore.ConsoleApp.DapperExamples
{
    public class DapperExample
    {
        private readonly SqlConnectionStringBuilder sqlConnectionStringBuilder;

        public DapperExample()
        {
            sqlConnectionStringBuilder = new SqlConnectionStringBuilder
            {
                DataSource = ".", // server name
                InitialCatalog = "ALTDotNetCore",
                UserID = "sa",
                Password = "sa@123",
            };
        }

        public void Run()
        {
            //Read();
            //Edit(2);
            //Edit(300);
            //Create("test 8.21", "test 2", "test 3");
            //Update(2, "test 6", "test 7", "test 8");
            //Delete(2);
        }

        private void Read()
        {
            #region Read / Retrieve

            string query = "select * from tbl_blog";
            using IDbConnection db = new SqlConnection(sqlConnectionStringBuilder.ConnectionString);

            List<BlogDataModel> lst = db.Query<BlogDataModel>(query).ToList();

            foreach (var item in lst)
            {
                Console.WriteLine(item.Blog_Id);
                Console.WriteLine(item.Blog_Title);
                Console.WriteLine(item.Blog_Author);
                Console.WriteLine(item.Blog_Content);
            }
            #endregion
        }

        private void Edit(int id)
        {
            #region Edit

            BlogDataModel blog = new BlogDataModel
            {
                Blog_Id = id
            };

            string query = "select * from tbl_blog where Blog_Id = @Blog_Id";
            using IDbConnection db = new SqlConnection(sqlConnectionStringBuilder.ConnectionString);
            BlogDataModel? item = db.Query<BlogDataModel>(query, blog).FirstOrDefault();
            if (item == null)
            {
                Console.WriteLine("No data found.");
                return;
            }

            Console.WriteLine(item.Blog_Id);
            Console.WriteLine(item.Blog_Title);
            Console.WriteLine(item.Blog_Author);
            Console.WriteLine(item.Blog_Content);

            #endregion
        }

        private void Create(string title, string author, string content)
        {
            #region Create

            BlogDataModel blog = new BlogDataModel
            {
                Blog_Title = title,
                Blog_Author = author,
                Blog_Content = content
            };

            string query = @"INSERT INTO [dbo].[Tbl_Blog]
           ([Blog_Title]
           ,[Blog_Author]
           ,[Blog_Content])
     VALUES
           (@Blog_Title
           ,@Blog_Author
           ,@Blog_Content)";

            using IDbConnection db = new SqlConnection(sqlConnectionStringBuilder.ConnectionString);
            int result = db.Execute(query, blog);

            string message = result > 0 ? "Saving Successful." : "Saving Failed.";
            Console.WriteLine(message);

            #endregion
        }

        private void Update(int id, string title, string author, string content)
        {
            #region Update

            BlogDataModel blog = new BlogDataModel
            {
                Blog_Id = id,
                Blog_Title = title,
                Blog_Author = author,
                Blog_Content = content
            };

            string query = @"
                            UPDATE [dbo].[Tbl_Blog]
                            SET [Blog_Title] = @Blog_Title
                                ,[Blog_Author] = @Blog_Author
                                ,[Blog_Content] = @Blog_Content
                            WHERE Blog_Id = @Blog_Id";

            using IDbConnection db = new SqlConnection(sqlConnectionStringBuilder.ConnectionString);
            int result = db.Execute(query, blog);

            string message = result > 0 ? "Updating Successful." : "Updating Failed.";
            Console.WriteLine(message);

            #endregion
        }

        private void Delete(int id)
        {
            #region Delete

            BlogDataModel blog = new BlogDataModel { Blog_Id = id };

            string query = @"
                            DELETE FROM [dbo].[Tbl_Blog]
                            WHERE Blog_Id = @Blog_Id";

            using IDbConnection db = new SqlConnection(sqlConnectionStringBuilder.ConnectionString);
            int result = db.Execute(query, blog);

            string message = result > 0 ? "Deleting Successful." : "Deleting Failed.";
            Console.WriteLine(message);

            #endregion
        }
    }
}
