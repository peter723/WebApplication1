using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1.Pages
{
    public partial class _default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            getServices();
            getblogs();
        }
        public void getServices()
        {
            if (!Page.IsPostBack)
            {
                string connectionString = ConfigurationManager.ConnectionStrings["MyConnectionString"].ConnectionString;

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "SELECT * FROM ServicesCompany";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            string title = "";
                            string Link = "";
                            String description = "";
                            while (reader.Read())
                            {

                                title = reader["Title_AR"].ToString();
                                Link = reader["Pic_URL"].ToString();
                                description= reader["Description_AR"].ToString();
                                Services.Text += "<div class=\"col-xl-3 col-md-6 d-flex\">";
                                Services.Text += "<div class=\"service-box service-style-1  h-100 flex-fill d-flex flex-column\">";

                                Services.Text += "<div class=\"service-img\">";
                                Services.Text += "<a href=\"service-details.html\">";
                                Services.Text += "<img src='" + Link + "' class='card-img-top img-fluid' />";
                                Services.Text += "</a>";
                                Services.Text += "</div>";

                                Services.Text += "<div class=\"service-content card-body d-flex flex-column\">";
                                Services.Text += "<h3 class=\"box-title mb-2\"><a href=\"service-details.html\">" + title + "</a></h3>";
                                Services.Text += "<p class=\"service-box_text mb-3 flex-grow-1\">" + description + "</p>";
                                Services.Text += "</div></div></div>";

                            }



                        }
                    }
                    connection.Close();
                }
            }
        }

        public void getblogs()
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

                            while (reader.Read())
                            {

                                Title_AR = reader["Title_AR"].ToString();
                                Title_En = reader["Title_En"].ToString();
                                Pic_URL = reader["Pic_URL"].ToString();
                                Dates = reader["Dates"].ToString();

                                Blogs.Text += "<div class=\"col-12 blog-grid4_wrapp\"> ";
                                Blogs.Text += "<div class=\"blog-grid4 th-ani style4 mt-24\"> ";
                                Blogs.Text += "<div class=\"box-content\"> ";
                                Blogs.Text += " <div class=\"blog-meta\"> ";
                                Blogs.Text += "<a class=\"author\" href=\"blog.html\">"+Dates+"</a> ";
                                Blogs.Text += " </div> ";
                                Blogs.Text += "<h3 class=\"box-title\"> ";
                                Blogs.Text += "<a href=\"blog-details.html\">"+ Title_AR + "</a> ";
                                Blogs.Text += " </h3>";
                                Blogs.Text += "<a href=\"blog-details.html?Title="+Title_AR+"\" class=\"th-btn style4 th-icon\">قراءة المزيد <i class=\"fa-light fa-arrow-right-long\"></i></a> ";
                                Blogs.Text += "</div> ";
                                Blogs.Text += " <div class=\"blog-img global-img\">";
                                Blogs.Text += " <img src=\"/"+Pic_URL+"\" alt=\"blog image\"> ";
                                Blogs.Text += " </div> ";
                                Blogs.Text += " </div> ";
                                Blogs.Text += " </div> ";



                            }



                        }
                    }
                    connection.Close();
                }
            }
        }

    }
}