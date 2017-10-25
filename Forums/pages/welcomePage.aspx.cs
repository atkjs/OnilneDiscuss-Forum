using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using Diu.DotNet.Forums.BusinessLayer;
namespace Forums.pages
{
    public partial class welcomePage : System.Web.UI.Page
    {
        AddForumsUserBusiness objBusiness = new AddForumsUserBusiness();
        DataSet objDataSetOne = new DataSet();
        DataSet objDataSetTwo = new DataSet();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                show();
                showTag();
            }
            
        }

        public void show()
        {

            objDataSetOne = objBusiness.viewAllQuestionBusiness();
            repeterShowQuestion.DataSource = objDataSetOne;
            repeterShowQuestion.DataBind();


           
        }

        public void showTag()
        {
            //objDataSetOne = objBusiness.viewAllQuestionBusiness();
            //RepeaterTag.DataSource = objDataSetOne;
            //RepeaterTag.DataBind();

            ForumEntities fEntity = new ForumEntities();
            RepeaterTag.DataSource = fEntity.ShowTags();
            RepeaterTag.DataBind();
        }


        protected void linkButtonAnswer_Click(object sender, EventArgs e)
        {
            Session.Contents.Remove("QuestionId");
            LinkButton lb = (LinkButton)sender;
            HiddenField hd = (HiddenField)lb.FindControl("HiddenQuestionId");

            int id = Convert.ToInt16(hd.Value);

            Response.Redirect("Answer.aspx?Parameter=" + id);
            
        }
        }
}