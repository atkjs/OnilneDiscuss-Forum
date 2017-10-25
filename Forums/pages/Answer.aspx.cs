using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using Diu.DotNet.Forums.BusinessLayer;
using Diu.DotNet.Forums.EntityLayer;

namespace Forums.pages
{
    public partial class Answer : System.Web.UI.Page
    {
        AnswerQuestion objEntity = new AnswerQuestion();
        AddForumsUserBusiness objBusiness = new AddForumsUserBusiness();
        DataSet objDataSetOne = new DataSet();
        DataSet objDataSetTwo = new DataSet();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["QuestionId"] ==null)
            {
                String Questionid = Request.QueryString["Parameter"].ToString();
                Session["QuestionId"] = Questionid;
            }
            if(Session["id"] == null)
            {
                Panelanswer.Visible = false;
            }
            else
            {
                Panelanswer.Visible = true;
            }
            
          showQuestion();
          showAnswer();
        }

        
        

        void showQuestion()
        {
            QuestionShowByQuestionId objEntityQuestion = new QuestionShowByQuestionId();

            objEntityQuestion.QuestionId = Convert.ToInt32(Session["QuestionId"]);

            objDataSetOne = objBusiness.viewUserQuestionByIdBusiness(objEntityQuestion);
            repeterShowQuestion.DataSource = objDataSetOne;
            repeterShowQuestion.DataBind();


          
        }

        void showAnswer()
        {
            QuestionShowByQuestionId objEntityQuestion = new QuestionShowByQuestionId();
            objEntityQuestion.QuestionId = Convert.ToInt32(Session["QuestionId"]);

            objDataSetTwo = objBusiness.viewAnswerQuestionByIdBusiness(objEntityQuestion);
            RepeaterAnswer.DataSource = objDataSetTwo;
            RepeaterAnswer.DataBind();

        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            int result;

            objEntity.AnswerDetails = txtAnswer.Text;
            objEntity.DateAndTime = DateTime.Now.ToString();
            objEntity.QuestionId = Convert.ToInt32(Session["QuestionId"]);

            if (Session["id"] == null)
            {
                string s = "alert('Please Login First')";
                ClientScript.RegisterStartupScript(this.GetType(), "script", s, true);
            }
            else
            {

                objEntity.UserId = Convert.ToInt32(Session["id"]);
                result = objBusiness.AddAnswer(objEntity);
                Response.Redirect("Answer.aspx");
            }
            txtAnswer.Text = "";
        }
    }
}