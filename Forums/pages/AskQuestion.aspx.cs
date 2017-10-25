using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Diu.DotNet.Forums.BusinessLayer;
using Diu.DotNet.Forums.EntityLayer;
namespace Forums.pages
{
    public partial class AskQuestion : System.Web.UI.Page
    {
        AddQuestion objEntity = new AddQuestion();
        AddForumsUserBusiness objBusiness = new AddForumsUserBusiness();

        protected void Page_Load(object sender, EventArgs e)
        {
       
        }

        protected void btnDubmit_Click(object sender, EventArgs e)
        {
            int result;
            objEntity.QuestionTitle = txtTitle.Text;
            objEntity.QuestionDetails = txtQuestion.Text;
            objEntity.Tags = txtTags.Text;
            objEntity.Date = System.DateTime.Now.ToString();
            if (Session["id"] == null)
            {
                string s = "alert('Please Login First')";
                ClientScript.RegisterStartupScript(this.GetType(), "script", s, true);
            }
            else
            {
            
                objEntity.UserId = Convert.ToInt32(Session["id"]);
                 result = objBusiness.AddQuestion(objEntity);
                Response.Redirect("welcomePage.aspx");
            }
           
        }

        
           protected void OpenWindow(object sender, EventArgs e)
        {
            string url = "popup.aspx";
            string s = "window.open('" + url + "', 'popup_window','width=300,height=100,left=100,top=100')";
            ClientScript.RegisterStartupScript(this.GetType(), "script", s, true);
        }

    
    }
}