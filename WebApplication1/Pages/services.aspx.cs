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
    public partial class services : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            getServices();
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
                                description = reader["Description_AR"].ToString();
                                Services.Text += "<div class=\"col-xl-3 col-md-6\">";
                                Services.Text += "<div class=\"service-box service-style-1\">";
                                Services.Text += "<div class=\"service-img\">";
                                Services.Text += "<a href=\"service-details.html\">";
                                Services.Text += "<img src='" + Link + "'>";
                                Services.Text += "</a>";
                                Services.Text += "</div>";
                                Services.Text += "<div class=\"service-content\">";
                                Services.Text += "<h3 class=\"box-title\">";
                                Services.Text += "<a href=\"service-details.html\">" + title + "</a></h3>";
                                Services.Text += "<p class=\"service-box_text\">" + description + "</p></div></div></div>";

                            }



                        }
                    }
                    connection.Close();
                }
            }
        }
    }
}