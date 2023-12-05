using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AEHKLMNSTZDotNetCore.ConsoleApp.AdoDotNetExamples
{
    public class AdoDotNetExample
    {
        private readonly SqlConnectionStringBuilder sqlConnectionStringBuilder;

        public AdoDotNetExample()
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
            Read();
            //Create("test1", "test 2", "test 3");
            //Edit(2);
            //Edit(300);
            //Update(2, "test 6", "test 7", "test 8");
            //Delete(2);
        }
        private void Read()
        {
            #region Read / Retrieve

            SqlConnection connection = new SqlConnection(sqlConnectionStringBuilder.ConnectionString);
            Console.WriteLine("Connection opening...");
            connection.Open();
            Console.WriteLine("Connection opened.");
            string query = "select * from tbl_blog";
            SqlCommand cmd = new SqlCommand(query, connection);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            Console.WriteLine("Connection closing...");
            connection.Close();
            Console.WriteLine("Connection closed.");
            foreach (DataRow row in dt.Rows)
            {
                Console.WriteLine(row["Blog_Id"]);
                Console.WriteLine(row["Blog_Title"]);
                Console.WriteLine(row["Blog_Author"]);
                Console.WriteLine(row["Blog_Content"]);
            }

            #endregion
        }
        private void Edit(int id)
        {
            #region Edit
            SqlConnection connection = new SqlConnection(sqlConnectionStringBuilder.ConnectionString);
            connection.Open();
            string query = "select * from tbl_blog where Blog_Id = @Blog_Id;";
            SqlCommand cmd = new SqlCommand(query,connection);
            cmd.Parameters.AddWithValue("@Blog_Id", id);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            connection.Close();
            if (dt.Rows.Count == 0)
            {
                Console.WriteLine("No data found.");
                return;
            }
            DataRow row = dt.Rows[0];
            Console.WriteLine(row["Blog_Id"]);
            Console.WriteLine(row["Blog_Title"]);
            Console.WriteLine(row["Blog_Author"]);
            Console.WriteLine(row["Blog_Content"]);
            #endregion
        }
        private void Create(string title , string author , string content)
        {
            #region Create
            SqlConnection connection = new SqlConnection(sqlConnectionStringBuilder.ConnectionString);
            connection.Open();
            string query = @"INSERT INTO [dbo].[Tbl_Blog]
           ([Blog_Title]
           ,[Blog_Author]
           ,[Blog_Content])
     VALUES
           (@Blog_Title
           ,@Blog_Author
           ,@Blog_Content)";

            SqlCommand cmd = new SqlCommand(query, connection);
            cmd.Parameters.AddWithValue("@Blog_Title", title);
            cmd.Parameters.AddWithValue("@Blog_Author", author);
            cmd.Parameters.AddWithValue("@Blog_Content", content);
            int result = cmd.ExecuteNonQuery();

            connection.Close();

            string message = result > 0 ? "Saving Successful." : "Saving Failed.";
            Console.WriteLine(message);

            #endregion
        }
        private void Update (int id , string title, string author, string content)
        {
            #region Update

            SqlConnection connection = new SqlConnection(sqlConnectionStringBuilder.ConnectionString);
            connection.Open();

            string query = @"
                            UPDATE [dbo].[Tbl_Blog]
                            SET [Blog_Title] = @Blog_Title
                                ,[Blog_Author] = @Blog_Author
                                ,[Blog_Content] = @Blog_Content
                            WHERE Blog_Id = @Blog_Id";
            SqlCommand cmd = new SqlCommand(query, connection);
            cmd.Parameters.AddWithValue("@Blog_Id", id);
            cmd.Parameters.AddWithValue("@Blog_Title", title);
            cmd.Parameters.AddWithValue("@Blog_Author", author);
            cmd.Parameters.AddWithValue("@Blog_Content", content);
            int result = cmd.ExecuteNonQuery();

            connection.Close();

            string message = result > 0 ? "Updating Successful." : "Updating Failed.";
            Console.WriteLine(message);

            #endregion
        }
        private void Delete (int id)
        {
            #region Delete
            SqlConnection connection = new SqlConnection(sqlConnectionStringBuilder.ConnectionString);
            connection.Open();

            string query = @"
                            DELETE FROM [dbo].[Tbl_Blog]
                            WHERE Blog_Id = @Blog_Id";
            SqlCommand cmd = new SqlCommand(query, connection);
            cmd.Parameters.AddWithValue("@Blog_Id", id);
            int result = cmd.ExecuteNonQuery();

            connection.Close();

            string message = result > 0 ? "Deleting Successful." : "Deleting Failed.";
            Console.WriteLine(message);

            #endregion
        }
    }
}
