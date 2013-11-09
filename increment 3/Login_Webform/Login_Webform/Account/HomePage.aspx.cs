using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Login_Webform.Account
{
    public partial class HomePage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            // handling case where user tries to access page without logging in
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
    }
}