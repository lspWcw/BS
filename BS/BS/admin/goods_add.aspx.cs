using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;

namespace BS.admin
{
    public partial class Goods_add : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            BSModel.Goods goods = new BSModel.Goods();
            goods.title = this.title.Text.Trim();
            goods.price = int.Parse(this.price.Text.Trim());
            goods.num = int.Parse(this.num.Text.Trim());
            goods.detail = this.detail.Text.Trim();
            goods.state = int.Parse(this.state.Text.Trim());
            goods.addtime = DateTime.Now;

            if (img.HasFile)
            {
                string fileName = DateTime.Now.Year.ToString() + DateTime.Now.Month.ToString() + DateTime.Now.Day.ToString() + DateTime.Now.Minute.ToString() + DateTime.Now.Second.ToString() + DateTime.Now.Millisecond.ToString() + Path.GetExtension(img.FileName);
                string filePath = "~/img/" + fileName;
                img.SaveAs(MapPath(filePath));
                goods.img = fileName;
            }

            if (BSBll.GoodsBll.Add(goods))
            {
                BSUtility.JsHelper.AlertAndRedirect("发布成功", "goods.aspx");
            }
            else 
            {
                BSUtility.JsHelper.AlertAndRedirect("发布失败", "goods_add.aspx");
            }
        }
    }
}