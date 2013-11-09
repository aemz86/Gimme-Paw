using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;

namespace Login_Webform.Account
{
    public partial class ViewImages : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            lblName.Text = Session["Username"].ToString();
            string[] filesindirectory = Directory.GetFiles(Server.MapPath("~/Images/" + Session["Username"].ToString()));
            List<String> images = new List<string>(filesindirectory.Count());

            foreach (string item in filesindirectory)
            {
                images.Add(String.Format("~/Images/"+Session["Username"].ToString()+"/{0}", System.IO.Path.GetFileName(item)));
            }

            RepeaterImages.DataSource = images;
            RepeaterImages.DataBind();
        }

        protected void LinkButton1_Click(object sender, EventArgs e)
        {
            Session["Username"] = lblName.Text;
            Response.Redirect("~/Account/Home.aspx");
        }
    }
}