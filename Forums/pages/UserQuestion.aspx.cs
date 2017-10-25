using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using Diu.DotNet.Forums.EntityLayer;
using Diu.DotNet.Forums.BusinessLayer;
namespace Forums.pages
{
    public partial class UserQuestion : System.Web.UI.Page
    {
        ShowUserQuestion objEntity = new ShowUserQuestion();
        AddForumsUserBusiness objBusiness = new AddForumsUserBusiness();
        DataSet objDataSetOne = new DataSet();

        protected void Page_Load(object sender, EventArgs e)
        {
            show();
        }

        public void show()
        {
            objEntity.UserId= Convert.ToInt32(Session["id"]);

            objDataSetOne = objBusiness.viewUserQuestionBusiness(objEntity);
            repeterShowQuestion.DataSource = objDataSetOne;
            repeterShowQuestion.DataBind();
        }
    }
}