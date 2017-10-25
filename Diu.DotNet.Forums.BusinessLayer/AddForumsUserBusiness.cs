using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using Diu.DotNet.Forums.EntityLayer;
using Diu.DotNet.Forums.DataAcessLayer;
namespace Diu.DotNet.Forums.BusinessLayer
{
  
    public class AddForumsUserBusiness
    {
        AddForumsUserData objDataLayer = new AddForumsUserData();
        DataSet ObjDataSet = new DataSet();
        DataSet ObjDataSetAnswer = new DataSet();

        public int AddUserBusiness(AddForumsUserEntity objEntity)
        {
            int result = 0;
            SqlParameter[] param = new SqlParameter[3];

            param[0] = new SqlParameter("@Name", SqlDbType.VarChar, 25 );
            param[0].Value = objEntity.Name;

            param[1] = new SqlParameter("@Email", SqlDbType.VarChar, 50);
            param[1].Value = objEntity.Email;

            param[2] = new SqlParameter("@Password", SqlDbType.VarChar, 25);
            param[2].Value = objEntity.Password;

            result = objDataLayer.AddUserDataLayer(param);

            return result;
        }

        public DataSet loginUserBusiness(loginUserEntity objEntity)
        {
           
            SqlParameter[] param = new SqlParameter[2];

            param[0] = new SqlParameter("@Email", SqlDbType.VarChar, 50);
            param[0].Value = objEntity.Email;

            param[1] = new SqlParameter("@Password", SqlDbType.VarChar, 25);
            param[1].Value = objEntity.Password;

            ObjDataSet = objDataLayer.loginUserDataLayer(param);
            return ObjDataSet;
        }

        public int AddQuestion(AddQuestion objEntity)
        {
            int result = 0;
            SqlParameter[] param = new SqlParameter[5];

            param[0] = new SqlParameter("@Title", SqlDbType.VarChar, 25);
            param[0].Value = objEntity.QuestionTitle;

            param[1] = new SqlParameter("@Details", SqlDbType.VarChar, 500);
            param[1].Value = objEntity.QuestionDetails;

            param[2] = new SqlParameter("@Tags", SqlDbType.VarChar, 25);
            param[2].Value = objEntity.Tags;

            param[3] = new SqlParameter("@DateAndTime", SqlDbType.VarChar, 25);
            param[3].Value = objEntity.Date;

            param[4] = new SqlParameter("@UserId", SqlDbType.Int);
            param[4].Value = objEntity.UserId;

            result = objDataLayer.AddUserQuestionDataLayer(param);

            return result;
        }

        public DataSet viewUserQuestionBusiness(ShowUserQuestion objEntity)
        {

            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@userId", SqlDbType.Int);
            param[0].Value = objEntity.UserId;  

            ObjDataSet = objDataLayer.viewUserQuestion(param);
            return ObjDataSet;
        }


        public DataSet viewAllQuestionBusiness()
        {
            ObjDataSet = objDataLayer.viewAllQuestionData();
            return ObjDataSet;
        }

        public DataSet viewUserQuestionByIdBusiness(QuestionShowByQuestionId objEntity)
        {
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@QuestionId", SqlDbType.Int);
            param[0].Value = objEntity.QuestionId;

            ObjDataSet = objDataLayer.viewUserByIdQuestion(param);
            return ObjDataSet;
        }

        public int AddAnswer(AnswerQuestion objEntity)
        {
            int result = 0;
            SqlParameter[] param = new SqlParameter[4];

            param[0] = new SqlParameter("@AnswerDetails", SqlDbType.VarChar, 500);
            param[0].Value = objEntity.AnswerDetails;

            param[1] = new SqlParameter("@DateAndTime", SqlDbType.VarChar, 25);
            param[1].Value = objEntity.DateAndTime;

            param[2] = new SqlParameter("@QuestionId", SqlDbType.Int);
            param[2].Value = objEntity.QuestionId;

            param[3] = new SqlParameter("@UserId", SqlDbType.Int);
            param[3].Value = objEntity.UserId;

            result = objDataLayer.AddUserAnswerDataLayer(param);

            return result;
        }

        public DataSet viewAnswerQuestionByIdBusiness(QuestionShowByQuestionId objEntity)
        {
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@QuestionId", SqlDbType.Int);
            param[0].Value = objEntity.QuestionId;

            ObjDataSetAnswer = objDataLayer.viewAnswerByIdQuestion(param);
            return ObjDataSetAnswer;
        }
    }
}
