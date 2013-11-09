using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using Microsoft.AspNet.Membership.OpenAuth;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;
using Bcrypter = BCrypt.Net;

namespace Login_Webform.Account
{
    public partial class Register : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
            //RegisterUser.ContinueDestinationPageUrl = Request.QueryString["ReturnUrl"];
        }

        protected void btnRegister_Click(object sender, EventArgs e)
        {

            string pw_hash = Bcrypter.BCrypt.HashPassword(tb_password.Text);
            //string EPass = encryptPassword(tb_password.Text);
            SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["dbString"].ConnectionString);
            conn.Open();
            string sql = "INSERT INTO UserTable (Username, Password, Email) values (@username, @password, @email)";
            //SqlCommand cmd = new SqlCommand("Insert into UserTable(Username, Password, Email)values('" + tb_username + "','" + tb_password + "', '" + tb_email + "')", conn);
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@username", tb_username.Text);
            cmd.Parameters.AddWithValue("@password", pw_hash);
            cmd.Parameters.AddWithValue("@email", tb_email.Text);

            cmd.ExecuteNonQuery();
            cmd.Dispose();

            conn.Close();

            Session["Username"] = tb_username.Text;
            string pathToCreate = "~/Images/" + Session["Username"].ToString();
            System.IO.Directory.CreateDirectory(Server.MapPath(pathToCreate));
            Response.Redirect("~/Account/Login.aspx");
        }
        
    }
}