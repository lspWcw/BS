using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BS.user
{
    public partial class index : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            BSModel.Users user = new BSModel.Users();
            user = (BSModel.Users)BSUtility.SessionHelper.GetSession("user");
            if (user != null)
            {
                this.username.Text = user.username;
            }
            else
            {
                BSUtility.JsHelper.AlertAndRedirect("尚未登录", "/login.aspx");
            }
            
        }
    }
}