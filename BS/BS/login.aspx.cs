using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BS
{
    public partial class login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string username = this.username.Text;
            string password = this.password.Text;

            if (BSBll.UsersBll.Login(username, password) == true)
            {
                BSModel.Users user = BSBll.UsersBll.GetUser(username);
                if (user.state == 1)
                {
                    BSUtility.SessionHelper.SetSession("user", user);
                    BSUtility.JsHelper.AlertAndRedirect("用户：" + username + " 登录成功", "/user/index.aspx");
                }
                else
                {
                    BSUtility.JsHelper.AlertAndRedirect("登录失败，账号已关闭", "login.aspx");
                }
            }
            else
            {
                BSUtility.JsHelper.AlertAndRedirect("登录失败", "login.aspx");
            }
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            BSUtility.JsHelper.Redirect("reg.aspx");
        }
    }
}