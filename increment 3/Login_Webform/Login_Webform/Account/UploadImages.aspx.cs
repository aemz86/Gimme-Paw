using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Login_Webform.Account
{
    public partial class UploadImages : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (HttpContext.Current.Session["Username"] == null)
            {
                Response.Redirect("Login.aspx");
            }
            else
            {
                lblName.Text = Session["Username"].ToString();

            }
        }

        protected void Button1_Click1(object sender, EventArgs e)
        {
            //string pathToCreate = "~/Images/" + "al";

            //string pathString = System.IO.Path.Combine(System.IO.Path.GetDirectoryName("~/Images/"), "al");
            string pathToCreate = "~/Images/" + Session["Username"].ToString()+"/";
            if(System.IO.Directory.Exists(Server.MapPath(pathToCreate)))
            {
                //string newS = Session["Username"].ToString();
                FileUpload1.SaveAs(Server.MapPath(pathToCreate + FileUpload1.FileName));
            }
            else
            {
                System.IO.Directory.CreateDirectory(Server.MapPath(pathToCreate));
                FileUpload1.SaveAs(Server.MapPath(pathToCreate + FileUpload1.FileName));
            }
            //if (!System.IO.Directory.Exists(pathString))

            //Response.Write("<% <script type='text/javascript'> alert("+pathString+") </script> %>");
            //Console.WriteLine(pathString);
            //System.IO.Directory.CreateDirectory(pathString);

            //FileUpload1.SaveAs(Server.MapPath("~/Images/" + FileUpload1.FileName));
            StatusLabel.Text = "Upload status: " + FileUpload1.FileName + " uploaded!" + pathToCreate;
        }

        protected void LinkButton1_Click(object sender, EventArgs e)
        {
            Session["Username"] = lblName.Text;
            Response.Redirect("Home.aspx");

        }
    }
}