using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BS
{
    public partial class good : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string id = Request["id"];
            BSModel.Goods goods = BSBll.GoodsBll.GetGoods(int.Parse(id));
            this.title.Text = goods.title;
            this.price.Text = goods.price.ToString();
            this.num.Text = goods.num.ToString();
            this.detail.Text = "景区详情：" + goods.detail;
            this.img.ImageUrl = "img/" + goods.img.ToString();
            this.img.Width = 250;
        }
    }
}