using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

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


using BCrypter = BCrypt.Net;


using WcfService1;

namespace WcfService1Tests
{
    
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void EncryptionTest()
        {
            SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["dbString"].ConnectionString);

            conn.Open();


            string stored_hash = "";

            //Declare the sql command
            SqlCommand cmd = new SqlCommand("Select * From userTable where username='" + "john" + "'", conn);
            SqlCommand cmd1 = new SqlCommand("Select password from userTable where username ='" + "john" + "'", conn);

            SqlDataReader reader1 = cmd1.ExecuteReader();
            while (reader1.Read())
            {

                stored_hash = reader1["password"].ToString().Trim();

            }
            reader1.Close();


            //close the connection
            conn.Close();


            Assert.IsTrue(BCrypter.BCrypt.Verify("lennon", stored_hash));

        }
    }
}
