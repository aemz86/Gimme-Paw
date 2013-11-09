using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Xml.Linq;
using System.Web.Services;
using System.Web.Script.Services;
using System.Data.Sql;
using System.Configuration;
using System.Data;

using BCrypter = BCrypt.Net;

namespace Login_Webform.Account
{
    public partial class Login : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            // redirect from here if user still/already logged in
            if (HttpContext.Current.Session["Username"] != null)
            {
                //Response.Redirect("Home.aspx");
            }

        }

        [WebMethod]
        public static void TestFn(object sender, EventArgs e)
        {

            //txtPassword.Text = "adsasd";
        }


        protected void btnLogin_Click(object sender, EventArgs e)
        {
            string stored_pwd = "";

            SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["dbString"].ConnectionString);
            //Open the connection
            conn.Open();
            SqlCommand cmd = new SqlCommand("Select * From UserTable where Username='" + txtUsername.Text + "'", conn);
            SqlCommand cmd1 = new SqlCommand("Select Password from UserTable where Username ='" + txtUsername.Text + "'", conn);
            SqlDataReader reader1 = cmd1.ExecuteReader();

            while (reader1.Read())
            {
                stored_pwd = reader1["password"].ToString().Trim();
            }

            //Session["Username"] = txtUsername.Text;
            reader1.Close();

            //close the connection
            conn.Close();

            if (BCrypter.BCrypt.Verify(txtPassword.Text, stored_pwd))
            {
                //Console.WriteLine("It matches");
                Session["Username"] = txtUsername.Text;
                Response.Redirect("~/Account/Home.aspx");
            }

            else
                //Console.WriteLine("It does not match");
                LoginStatus.Text = "Login Failed. Try again.";


            //Session["Failure"] = "login failed";
            //Response.Write(@"<script language='javascript'>alert('"+txtUsername.Text+"');</script>");
            
            
            //Response.Redirect("~/Account/Home.aspx");
        }

        

    }
}