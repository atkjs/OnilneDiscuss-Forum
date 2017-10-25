using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace Diu.DotNet.Forums.DataAcessLayer
{
    public class AddForumsUserData
    {
     
        static public string getConnection()
        {
            string connectionString = ConfigurationManager.AppSettings["ConnectionString"].ToString();
            return connectionString;
        }
        SqlConnection ObjConnection = new SqlConnection(getConnection());
        SqlCommand ObjCommand = null;
        SqlDataAdapter ObjAdapter = null;
        DataSet ObjDataSet = new DataSet();
        DataSet ObjDataSetAnswer = new DataSet();

        public int AddUserDataLayer(SqlParameter[] objParameter)
        {
            int result = 0;
            ObjCommand = new SqlCommand("addUser", ObjConnection);
            ObjCommand.CommandType = CommandType.StoredProcedure;
            ObjCommand.Parameters.AddRange(objParameter);
            ObjConnection.Open();
            result = ObjCommand.ExecuteNonQuery();
            ObjConnection.Close();
            return result;
        }

        public DataSet loginUserDataLayer(SqlParameter[] objParameter)
        {
            ObjCommand = new SqlCommand("loginUser", ObjConnection);
            ObjCommand.CommandType = CommandType.StoredProcedure;
            ObjCommand.Parameters.AddRange(objParameter);
            ObjConnection.Open();
            ObjAdapter = new SqlDataAdapter(ObjCommand);
            ObjAdapter.Fill(ObjDataSet);
            ObjConnection.Close();
            return ObjDataSet;
        }

        public int AddUserQuestionDataLayer(SqlParameter[] objParameter)
        {
            int result = 0;
            ObjCommand = new SqlCommand("AddQuestion", ObjConnection);
            ObjCommand.CommandType = CommandType.StoredProcedure;
            ObjCommand.Parameters.AddRange(objParameter);
            ObjConnection.Open();
            result = ObjCommand.ExecuteNonQuery();
            ObjConnection.Close();
            return result;
        }

        public DataSet viewUserQuestion(SqlParameter[] objParameter)
        {
            ObjCommand = new SqlCommand("viewUserQuestion", ObjConnection);
            ObjCommand.CommandType = CommandType.StoredProcedure;
            ObjCommand.Parameters.AddRange(objParameter);
            ObjConnection.Open();
            ObjAdapter = new SqlDataAdapter(ObjCommand);
            ObjAdapter.Fill(ObjDataSet);
            ObjConnection.Close();
            return ObjDataSet;
        }


        public DataSet viewAllQuestionData()
        {
            ObjCommand = new SqlCommand("viewAllQuestions", ObjConnection);
            ObjCommand.CommandType = CommandType.StoredProcedure;
            ObjConnection.Open();
            ObjAdapter = new SqlDataAdapter(ObjCommand);
            ObjAdapter.Fill(ObjDataSet);
            ObjConnection.Close();
            return ObjDataSet;
        }

        public DataSet viewUserByIdQuestion(SqlParameter[] objParameter)
        {
            ObjCommand = new SqlCommand("showQuestionyId", ObjConnection);
            ObjCommand.CommandType = CommandType.StoredProcedure;
            ObjCommand.Parameters.AddRange(objParameter);
            ObjConnection.Open();
            ObjAdapter = new SqlDataAdapter(ObjCommand);
            ObjAdapter.Fill(ObjDataSet);
            ObjConnection.Close();
            return ObjDataSet;
        }

        public int AddUserAnswerDataLayer(SqlParameter[] objParameter)
        {
            int result = 0;
            ObjCommand = new SqlCommand("AddAnswer", ObjConnection);
            ObjCommand.CommandType = CommandType.StoredProcedure;
            ObjCommand.Parameters.AddRange(objParameter);
            ObjConnection.Open();
            result = ObjCommand.ExecuteNonQuery();
            ObjConnection.Close();
            return result;
        }

        public DataSet viewAnswerByIdQuestion(SqlParameter[] objParameter)
        {
            ObjCommand = new SqlCommand("showAnswerId", ObjConnection);
            ObjCommand.CommandType = CommandType.StoredProcedure;
            ObjCommand.Parameters.AddRange(objParameter);
            ObjConnection.Open();
            ObjAdapter = new SqlDataAdapter(ObjCommand);
            ObjAdapter.Fill(ObjDataSetAnswer);
            ObjConnection.Close();
            return ObjDataSetAnswer;
        }

    }
}
