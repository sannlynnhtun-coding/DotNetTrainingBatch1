using AEHKLMNSTZDotNetCore.WindowFormApp.Models;
using Dapper;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AEHKLMNSTZDotNetCore.WindowFormApp
{
    public partial class FrmBlog : Form
    {
        private readonly AppDbContext _context;
        private readonly SqlConnection _sqlConnection;

        public FrmBlog()
        {
            AppConfigService appConfigService = new AppConfigService();
            _context = new AppDbContext(appConfigService.GetDbConnection());
            _sqlConnection = new SqlConnection(appConfigService.GetDbConnection());

            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            BlogDataModel blog = new BlogDataModel
            {
                Blog_Author = txtAuthor.Text,
                Blog_Content = txtContent.Text,
                Blog_Title = txtTitle.Text
            };

            #region EF
            _context.Blogs.Add(blog);
            var result = _context.SaveChanges();
            string message = result > 0 ? "Saving Successful." : "Saving Failed.";
            MessageBox.Show(message, "Alert", MessageBoxButtons.OK, result > 0 ? MessageBoxIcon.Information : MessageBoxIcon.Error);
            #endregion

            #region Dapper
            //       string query = $@"INSERT INTO [dbo].[Tbl_Blog]
            //      ([Blog_Title]
            //      ,[Blog_Author]
            //      ,[Blog_Content])
            //VALUES
            //      (@Blog_Title
            //      ,@Blog_Author
            //      ,@Blog_Content)";
            //       using (IDbConnection db = new SqlConnection(_sqlConnection.ConnectionString))
            //       {
            //           var result = db.Execute(query, blog);
            //           string message = result > 0 ? "Saving Successful." : "Saving Failed.";
            //           MessageBox.Show(message, "Alert", MessageBoxButtons.OK, result > 0 ? MessageBoxIcon.Information : MessageBoxIcon.Error);
        //}
            #endregion

            txtAuthor.Clear();
            txtContent.Clear();
            txtTitle.Clear();
            txtTitle.Focus();

        }
    }
}
