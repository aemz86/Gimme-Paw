using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Login_Webform.Account
{
    public partial class Home : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //makes sure user is logged in
            if (HttpContext.Current.Session["Username"] == null)
            {
                Response.Redirect("Login.aspx");
            }
            else
            {
                lblName.Text = Session["Username"].ToString();

            }
        }

        protected void lnkbtnLogout_Click(object sender, EventArgs e)
        {
            Session.Clear();

            Response.Redirect("~/Account/Login.aspx");
        }

        protected void ImgUpload_Click(object sender, EventArgs e)
        {
            Session["Username"] = lblName.Text;

            Response.Redirect("~/Account/UploadImages.aspx");
        }

        protected void viewImages_Click(object sender, EventArgs e)
        {
            Session["Username"] = lblName.Text;

            Response.Redirect("~/Account/ViewImages.aspx");
        }
    }
}