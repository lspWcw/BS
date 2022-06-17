using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;

namespace BS.admin
{
    public partial class goods_edit : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack) 
            {
                string goodId = Request.QueryString["id"];
                BSModel.Goods good1 = BSBll.GoodsBll.GetGoods(int.Parse(goodId));
                this.goodsid.Value = good1.id.ToString();
                this.title.Text = good1.title;
                this.price.Text = good1.price.ToString();
                this.num.Text = good1.num.ToString();
                this.detail.Text = good1.detail;
                this.state.Text = good1.state.ToString();
                this.oldImg.Value = good1.img;
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            BSModel.Goods goods = new BSModel.Goods();
            goods.id = int.Parse(this.goodsid.Value);
            goods.title = this.title.Text;
            goods.price = int.Parse(this.price.Text);
            goods.num = int.Parse(this.num.Text);
            goods.detail = this.detail.Text;
            goods.state = int.Parse(this.state.Text);

            if (img.HasFile)
            {
                string fileName = DateTime.Now.Year.ToString() + DateTime.Now.Month.ToString() + DateTime.Now.Day.ToString() + DateTime.Now.Minute.ToString() + DateTime.Now.Second.ToString() + DateTime.Now.Millisecond.ToString() + Path.GetExtension(img.FileName);
                string filePath = "~/img/" + fileName;
                img.SaveAs(MapPath(filePath));
                goods.img = fileName;
            }
            else
            {
                goods.img = this.oldImg.Value;
            }

            if (BSBll.GoodsBll.UpGoods(goods))
            {
                BSUtility.JsHelper.AlertAndRedirect("编辑成功", "goods.aspx");
            }
            else
            {
                BSUtility.JsHelper.AlertAndRedirect("编辑失败", "goods.aspx");
            }
        }
    }
}