using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BS.user
{
    public partial class shopping_add : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            BSModel.Users user1 = new BSModel.Users();
            user1 = (BSModel.Users)BSUtility.SessionHelper.GetSession("user");
            if (user1 != null)
            {
                BSModel.Shopping shopping = new BSModel.Shopping();
                int id = int.Parse(Request.QueryString["id"].ToString());
                BSModel.Goods good1 = BSBll.GoodsBll.GetGoods(id);
                shopping.goods = good1;
                shopping.user = user1;
                shopping.num = 1;
                shopping.state = 0;
                shopping.addtime = DateTime.Now;

                if (BSBll.ShoppingBll.ShoppingList(good1.id, user1.id, 0).Count > 0)
                {
                    BSBll.ShoppingBll.UpdataNum(good1.id, user1.id, 0);
                    BSUtility.JsHelper.AlertAndRedirect("操作成功", "/user/shopping.aspx");
                }
                else
                {
                    if (BSBll.ShoppingBll.Add(shopping))
                    {
                        BSUtility.JsHelper.AlertAndRedirect("操作成功", "/user/shopping.aspx");
                    }
                    else
                    {
                        BSUtility.JsHelper.AlertAndRedirect("操作失败", "/user/shopping.aspx");
                    }
                }

            }
            else
            {
                BSUtility.JsHelper.AlertAndRedirect("尚未登录", "/login.aspx");
            }
            
        }
    }
}