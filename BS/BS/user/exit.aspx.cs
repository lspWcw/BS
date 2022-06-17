using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BS.user
{
    public partial class exit : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            BSUtility.SessionHelper.SetSession("user", null);
            BSUtility.JsHelper.Redirect("/login.aspx");
        }
    }
}