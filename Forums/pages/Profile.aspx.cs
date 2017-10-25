using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Forums.pages
{
    public partial class Profile : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            viewPanel();
           // PanelView.Visible = false;
            //PanelAddProfile.Visible = false;

        }
        ForumEntities fEntity = new ForumEntities();
        
        userDetail user = new userDetail();

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            string email = Session["Email"].ToString();
            var userDetails = fEntity.tbl_user.Where(x => x.Email == email).First();
            if (userDetails != null)
            {
                string status = userDetails.UserId.ToString();

                user.UserId =Convert.ToInt32(status);
             
                user.Phone = txtPhone.Text;
                user.location = txtLocation.Text;
                user.carear = txtProfession.Text;
                user.about = txtAbout.Text;

                fEntity.AddTouserDetails(user);
                fEntity.SaveChanges();
            }
            
        }

        void viewPanel()
        {
            string email = Session["Email"].ToString();
            var userDetails = fEntity.tbl_user.Where(x => x.Email == email).First();
            if (userDetails != null)
            {
                string status = userDetails.UserId.ToString();
                int id= Convert.ToInt32(status);

                var userDetailsId = fEntity.userDetails.Where(x => x.UserId == id).FirstOrDefault();
                if (userDetailsId != null)
                {
                    PanelView.Visible = true;
                    PanelAddProfile.Visible = false;
                    repeterShowUserInformation.DataSource = fEntity.ShowUserDetails(id);
                    repeterShowUserInformation.DataBind();
                }
                else
                {
                    PanelView.Visible = false;
                    PanelAddProfile.Visible = true;
                }
            }
        }
    }
}