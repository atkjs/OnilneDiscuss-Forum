using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Forums
{
    public partial class index : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["id"] == null)
            {
                lblLogin.Text = "Login";
                btnsign.Text = "Sign Up";
            }
            else
            {
                lblLogin.Text = Convert.ToString(Session["Email"]);
                btnsign.Text = "Log Out";
            }
        }

        protected void btnsign_Click(object sender, EventArgs e)
        {
            if (Session["id"] == null)
            {
                Response.Redirect("SignUp.aspx");
            }
            else
            {
                Session.Abandon();
                Response.Redirect("welcomePage.aspx");
            }
        }
    }
}