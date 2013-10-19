using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using System.Data.SqlClient;
using System.Configuration;
using System.Web;
using System.IO;
using System.Collections.Specialized;

using System.Net.Mail;

using BCrypter = BCrypt.Net;



namespace WcfService1
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    public class Service1 : IService1
    {
        


        public string encryptPassword(string password)
        {
            string pw_hash = BCrypter.BCrypt.HashPassword(password);
            return pw_hash;
        }
        
        
        public void sendEmail(string email)
        {
            MailMessage mail = new MailMessage();
            SmtpClient SmtpServer = new SmtpClient("smtp.gmail.com");

            mail.From = new MailAddress("gimmepaw1@gmail.com");
            mail.To.Add(email);
            mail.Subject = "<<<<< DON'T IGNORE >>>>> Test Mail from C# program";
            mail.Body = "Hey guys!! This is for testing sending from C# code using my GMAIL account. Let me know if it works!! ----- Soumick :)";

            SmtpServer.Port = 587;

            SmtpServer.Credentials = new System.Net.NetworkCredential("gimmepaw1", "umkc2013");
            SmtpServer.EnableSsl = true;

            SmtpServer.Send(mail);

        }

        //change to void
        [WebInvoke(Method = "GET", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json, UriTemplate = "signin/{username}/{password}")]
        public bool GetUser(string username, string password)
        {
            
            
            SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["dbString"].ConnectionString);


            //Open the connection
            conn.Open();
            //string pw_hash = password;

            //string pw_hash;

            //string username2 = "";
            string stored_hash= "";
            //string email= "";

            //Declare the sql command
            SqlCommand cmd = new SqlCommand("Select * From userTable where username='" + username + "'", conn);
            SqlCommand cmd1 = new SqlCommand("Select password from userTable where username ='" + username + "'", conn);
            //SqlCommand cmd = new SqlCommand("Select * From userTable where name='" + username + "'" + " and password='" + password+ "'" , conn);
            SqlDataReader reader1 = cmd1.ExecuteReader();
            while (reader1.Read())
            {
                //username2 = username2 + ";" + reader["username"].ToString();
                //stored_hash= password+ ";" + reader["password"].ToString();
                stored_hash = reader1["password"].ToString().Trim();
                //email= email+ ";" + reader["email"].ToString();
            }
            reader1.Close();
            //bool verifiedPassword = BCrypter.BCrypt.Verify(password, stored_hash);


            //close the connection
            conn.Close();

            /*
            UserTable newUser = 
                new UserTable()
            {
                username= username,
                password = password,
                email = email
            };
             */
            //if (BCrypter.BCrypt.Verify(pw_hash, stored_hash))
            if (BCrypter.BCrypt.Verify(password, stored_hash))
                //Console.WriteLine("It matches");
                return true;
            else
                //Console.WriteLine("It does not match");
                return false;
        }

        [WebInvoke(Method = "POST", UriTemplate = "insert", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json,
            BodyStyle = WebMessageBodyStyle.Wrapped)]
        public UserTable InsertUser(UserTable user)
        {
            string EPass = encryptPassword(user.password);

            
            SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["dbString"].ConnectionString);

            conn.Open();

            SqlCommand cmd = new SqlCommand("Insert into UserTable(username, password, email)values('" + user.username + "','" + EPass + "', '" + user.email + "')", conn);
            //SqlCommand cmd = new SqlCommand("Insert into UserTable(username, password, email)values('" + user.username + "','" + user.password + "', '" + user.email + "')", conn);
          
            cmd.ExecuteNonQuery();
            cmd.Dispose();

            conn.Close();
            
            UserTable newUser =
                new UserTable()
                {
                    username = user.username,
                    password = EPass,
                    //password = user.password,
                    email = user.email
                };

            sendEmail(newUser.email);

            return newUser;
        }
    }


}
