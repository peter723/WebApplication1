using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Services.Description;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1.Pages
{
    public partial class blog : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            getarticls();
        }
        public void getarticls()
        {
            if (!Page.IsPostBack)
            {
                string connectionString = ConfigurationManager.ConnectionStrings["MyConnectionString"].ConnectionString;

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "SELECT * FROM blogsArticle";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            string Title_AR = "";
                            string Title_En = "";
                            String Pic_URL = "";
                            String Dates = "";
                            String Description = "";
                            string BlogsPic_URL = "";
                            while (reader.Read())
                            {

                                Title_AR = reader["Title_AR"].ToString();
                                Title_En = reader["Title_En"].ToString();
                                Pic_URL = reader["Pic_URL"].ToString();
                                Dates = reader["Dates"].ToString();
                                Description = reader["Description1"].ToString();
                                BlogsPic_URL = reader["BlogsPic_URL"].ToString();

                                Articls.Text += "<div class=\"th-blog blog-single has-post-thumbnail\">";
                                Articls.Text += "<div class=\"blog-img\">";
                                Articls.Text += "<a href=\"blog-details.html\"><img src=\"/" + BlogsPic_URL + "\" alt=\"Blog Image\"></a>";
                                Articls.Text += "</div>";
                                Articls.Text += " <div class=\"blog-content\">";
                                Articls.Text += "<div class=\"blog-meta\">";
                                Articls.Text += "<a class=\"author\" href=\"blog.html\"><i class=\"fa-light fa-user\"></i>أيمن مداح</a>";
                                Articls.Text += "<a href=\"blog.html\"><i class=\"fa-regular fa-calendar\"></i>"+ Dates + "</a>\r\n   </div> ";
                                Articls.Text += "<h2 class=\"blog-title\">";
                                Articls.Text += " <a href=\"blog-details.aspx?Title="+ Title_AR + "\">" + Title_AR + "</a></h2>";
                                Articls.Text += "<p class=\"blog-text\">"+ Description + "</p>";
                                Articls.Text += " <a href=/blog-details.aspx?Title="+ Title_AR + "\" class=\"th-btn style4 th-icon\"> المزيد <i class=\"fa-light fa-arrow-right-long\"></i></a>";
                                Articls.Text += " </div> ";
                                Articls.Text += " </div> ";



                            }



                        }
                    }
                    connection.Close();
                }
            }
        }
    }
}