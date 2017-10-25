using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using Diu.DotNet.Forums.EntityLayer;
using Diu.DotNet.Forums.BusinessLayer;
namespace Forums.Account
{
    public partial class Login : System.Web.UI.Page
    {
        loginUserEntity objEntity = new loginUserEntity();
        AddForumsUserBusiness objBusiness = new AddForumsUserBusiness();
        DataSet objDataSetOne = new DataSet();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (Session["Email"] == null)
                {
                    Panel1.Visible = false;
                    PanelLogin.Visible = true;
                }
                else
                {
                    Panel1.Visible = true;
                    PanelLogin.Visible = false;
                }
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("SignUp.aspx");
        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            Session["Email"] = txtEmail.Text;
            objEntity.Email = txtEmail.Text;
            objEntity.Password = txtPassword.Text;
            objDataSetOne = objBusiness.loginUserBusiness(objEntity);
            if (objDataSetOne.Tables[0].Rows.Count == 1)
            {
                hiddenUserId.Value= objDataSetOne.Tables[0].Rows[0]["UserId"].ToString();
                Session["id"] = hiddenUserId.Value;
                Response.Redirect("Profile.aspx");
            }
            else
            {
                lblErroeMessage.Text = "Sorry Email or Password are Incorrct";
            }
        }
    }
}