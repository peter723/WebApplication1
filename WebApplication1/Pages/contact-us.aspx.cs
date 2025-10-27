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
    public partial class contact_us : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Send_Click(object sender, EventArgs e)
        {
           
                string connectionString = ConfigurationManager.ConnectionStrings["MyConnectionString"].ConnectionString;

                using (SqlConnection connection = new SqlConnection(connectionString))
                {

                    string sqlQuery = "INSERT INTO ContactUS  (Name, Email,Number,Subject,message) VALUES (@Name, @Email,@Number ,@Subject, @message)";
                    using (SqlCommand command = new SqlCommand(sqlQuery, connection))
                    {
                        command.Parameters.AddWithValue("@Name", TXTName.Text);
                        command.Parameters.AddWithValue("@Email", TXTEmail.Text);
                        command.Parameters.AddWithValue("@Number", TXTNumber.Text);
                        command.Parameters.AddWithValue("@Subject", TXTSubject.Text);
                        command.Parameters.AddWithValue("@message", TXTmessage.Text);
                        connection.Open();
                        command.ExecuteNonQuery();
                        connection.Close();
                    text.Visible = true;

                    // ...
                }


                  
                }
           
            
        }
    }
}