using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BS.user
{
    public partial class order : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            int amount = 0;

            BSModel.Users user1 = new BSModel.Users();
            user1 = (BSModel.Users)BSUtility.SessionHelper.GetSession("user");
            List<BSModel.Shopping> list = BSBll.ShoppingBll.ShoppingList(user1.id);

            for (int i = 0; i < list.Count; i++)
            {
                amount = amount + list[i].goods.price * list[i].num;
            }
            this.amount.Text = amount.ToString();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            BSModel.Users user1 = new BSModel.Users();
            user1 = (BSModel.Users)BSUtility.SessionHelper.GetSession("user");
            string orderNum = DateTime.Now.Year.ToString() + DateTime.Now.Month.ToString() + DateTime.Now.Day.ToString() + DateTime.Now.Minute.ToString() + DateTime.Now.Second.ToString() + DateTime.Now.Millisecond.ToString();
            BSModel.Order order1 = new BSModel.Order();
            order1.id = orderNum;
            order1.user = user1;
            order1.amount = int.Parse(this.amount.Text);
            order1.state = 1;
            order1.addtime = DateTime.Now;

            if (BSBll.OrderBll.Add(order1))
            {
                BSBll.ShoppingBll.updateShopping(orderNum,user1.id,0);
                BSUtility.JsHelper.AlertAndRedirect("下单成功", "/user/order_list.aspx");
            }
            else
            {
                BSUtility.JsHelper.AlertAndRedirect("下单失败", "/user/order_list.aspx");
            }
        }
    }
}