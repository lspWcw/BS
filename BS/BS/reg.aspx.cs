using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BS
{
    public partial class reg : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            BSModel.Users user = new BSModel.Users();
            user.username = this.username.Text;
            user.password = this.password.Text;
            user.name = this.name.Text;
            user.address = this.address.Text;
            user.sex = int.Parse(this.sex.Text);
            user.mobile = this.mobile.Text;
            user.state = 1;
            user.addtime = DateTime.Now;

            if (BSBll.UsersBll.Search(this.username.Text) == false)
            {
                BSUtility.JsHelper.AlertAndRedirect("注册失败，用户名已存在", "reg.aspx");
            }
            else if (BSBll.UsersBll.Add(user) == true)
            {
                BSUtility.JsHelper.AlertAndRedirect("注册成功", "login.aspx");
            }
            else
            {
                BSUtility.JsHelper.AlertAndRedirect("注册失败", "reg.aspx");
            }
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            BSUtility.JsHelper.Redirect("login.aspx");
        }
    }
}