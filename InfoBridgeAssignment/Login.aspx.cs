using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace InfoBridgeAssignment
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            if(TextUserName.Text=="admin" && TextPassword.Text=="admin123")
            {
                Response.Redirect("~/Employee.aspx");
            }
            else
            {
                lblError.ForeColor=System.Drawing.Color.Red;
                lblError.Text = "Username & Password is Invalid";
            }
        }
    }
}