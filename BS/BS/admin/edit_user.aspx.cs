using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BS
{
    public partial class edit_user : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                string id = Request.QueryString["id"];
                if (id != null) {
                    BSModel.Users user = BSBll.UsersBll.GetUser(int.Parse(id));
                    this.password.Text = user.password;
                    this.name.Text = user.name;
                    this.address.Text = user.address;
                    this.sex.Text = user.sex.ToString();
                    this.mobile.Text = user.mobile;
                    this.state.Text = user.state.ToString();
                    this.id.Value = user.id.ToString();
                }
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            BSModel.Users user = new BSModel.Users();
            user.password = this.password.Text;
            user.name = this.name.Text;
            user.address = this.address.Text;
            user.sex = int.Parse(this.sex.Text);
            user.mobile = this.mobile.Text;
            user.state = int.Parse(this.state.Text); ;
            user.id = int.Parse(this.id.Value);

            if (BSBll.UsersBll.UpUser(user))
            {
                BSUtility.JsHelper.AlertAndRedirect("编辑成功", "user.aspx");
            }
            else
            {
                BSUtility.JsHelper.AlertAndRedirect("编辑失败", "user.aspx");
            }
        }

        protected void HiddenField1_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}