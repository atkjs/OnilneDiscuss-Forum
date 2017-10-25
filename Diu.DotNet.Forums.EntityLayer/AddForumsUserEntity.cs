using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diu.DotNet.Forums.EntityLayer
{
    public class AddForumsUserEntity
    {
        public String Name { get; set; }
        public String Email { get; set; }
        public String Password { get; set; }
    }

    public class loginUserEntity
    {
        public String Email { get; set; }
        public String Password { get; set; }
    }

    public class AddQuestion
    {
        public String QuestionTitle { get; set; }
        public String QuestionDetails { get; set; }
        public String Tags { get; set; }
        public String Date { get; set; }
        public int UserId { get; set; }
    }

    public class ShowUserQuestion
    {
        public int UserId { get; set; }
    }

    public class AnswerQuestion
    {
        public String AnswerDetails { get; set; }
        public String DateAndTime { get; set; }
        public int QuestionId { get; set; }
        public int UserId { get; set; }
    }

    public class QuestionShowByQuestionId
    {
        public int QuestionId { get; set; }
    }

}
