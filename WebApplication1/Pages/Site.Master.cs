using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Configuration;

namespace WebApplication1.Pages
{
    public partial class Site : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!Page.IsPostBack)
            {
                string connectionString = ConfigurationManager.ConnectionStrings["MyConnectionString"].ConnectionString;

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "SELECT * FROM Header";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            string title = "";
                            string Link = "";
                            while (reader.Read())
                            {

                                title = reader["TitleAR"].ToString();
                                Link = reader["URLAr"].ToString();
                                Litheader.Text += " <li class='menu-item mega-menu-wrap'>";
                                Litheader.Text += "<a class='text-white ' href='" + Link + "'>" + title + "</a>";
                                Litheader.Text += "</li>";
                                Litheadermobile.Text += " <li class='menu-item'>";
                                Litheadermobile.Text += "<a href='" + Link + "'>" + title + "</a>";
                                Litheadermobile.Text += "</li>";


                                
                            }
                          
                            

                        }
                    }
                    connection.Close();
                }
            }

        }
    }
}