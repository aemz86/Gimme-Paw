using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Login_Webform.Account
{
    public partial class no_master_test : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click1(object sender, EventArgs e)
        {
            // save the image uploaded from the form
            // change the filename to something user specific
            FileUpload1.SaveAs(Server.MapPath("~/Images/" + FileUpload1.FileName));
            StatusLabel.Text = "Upload status: " + FileUpload1.FileName +  " uploaded!";


        }



    }
}