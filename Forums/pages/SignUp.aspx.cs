using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Diu.DotNet.Forums.BusinessLayer;
using Diu.DotNet.Forums.EntityLayer;
namespace Forums.Account
{
    public partial class SignUp : System.Web.UI.Page
    {
        AddForumsUserEntity ObjEntity = new AddForumsUserEntity();
        AddForumsUserBusiness objBusiness = new AddForumsUserBusiness();

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSignUp_Click(object sender, EventArgs e)
        {
            int result = 0;
            ObjEntity.Name = txtname.Text;
            ObjEntity.Email = txtEmail.Text;
            ObjEntity.Password = txtPassword.Text;

            result = objBusiness.AddUserBusiness(ObjEntity);

            txtEmail.Text = "";
            txtname.Text = "";

        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            Response.Redirect("Login.aspx");
        }
    }
}