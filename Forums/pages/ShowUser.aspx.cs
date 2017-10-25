using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Forums.pages
{
    public partial class ShowUser : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            ForumEntities fEntity = new ForumEntities();
            DataUser.DataSource = fEntity.ShowUser();
            DataUser.DataBind();
        }
    }
}