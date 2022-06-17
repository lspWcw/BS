using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BS.user
{
    public partial class edit : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                BSModel.Users user = new BSModel.Users();
                user = (BSModel.Users)BSUtility.SessionHelper.GetSession("user");
                this.password.Text = user.password;
                this.name.Text = user.name;
                this.address.Text = user.address;
                this.sex.Text = user.sex.ToString();
                this.mobile.Text = user.mobile;
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            BSModel.Users user = new BSModel.Users();
            user = (BSModel.Users)BSUtility.SessionHelper.GetSession("user");
            user.password = this.password.Text;
            user.name = this.name.Text;
            user.address = this.address.Text;
            user.sex = int.Parse(this.sex.Text);
            user.mobile = this.mobile.Text;

            if (BSBll.UsersBll.UpUser(user))
            {
                BSUtility.JsHelper.AlertAndRedirect("修改成功", "index.aspx");
            }
            else
            {
                BSUtility.JsHelper.AlertAndRedirect("修改失败", "index.aspx");
                
            }
        }

    }
}