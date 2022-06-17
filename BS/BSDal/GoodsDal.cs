using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace BSDal
{
    public class GoodsDal
    {
        public static bool Add(BSModel.Goods goods)
        {
            bool result = false;
            string strsql = "insert into t_goods (title,price,num,img,detail,state,addtime)values('" + goods.title + "','" + goods.price + "','" + goods.num + "','" + goods.img + "','" + goods.detail + "','" + goods.state + "','" + goods.addtime + "')";
            int i = BSUtility.MsSqlHelper.ExecuteSql(strsql);
            if (i > 0)
            {
                return true;
            }
            return result;
        }
        public static bool UpGoods(BSModel.Goods goods)
        {
            bool result = false;
            string strsql = "update t_goods set title = '" + goods.title + "',price = '" + goods.price + "',num = '" + goods.num + "',detail = '" + goods.detail + "',state = '" + goods.state + "',img = '" + goods.img + "' where id='" + goods.id + "'";
            int i = BSUtility.MsSqlHelper.ExecuteSql(strsql);
            if (i > 0)
            {
                return true;
            }
            return result;
        }
        public static List<BSModel.Goods> DtToList(DataTable dataTable)
        {
            List<BSModel.Goods> list = new List<BSModel.Goods>();
            for (int i = 0; i < dataTable.Rows.Count; i++)
            {
                BSModel.Goods goods = new BSModel.Goods();
                goods.id = Convert.ToInt32(dataTable.Rows[i]["id"].ToString());
                goods.title = dataTable.Rows[i]["title"].ToString();
                goods.price = Convert.ToInt32(dataTable.Rows[i]["price"].ToString());
                goods.num = Convert.ToInt32(dataTable.Rows[i]["num"].ToString());
                goods.img = dataTable.Rows[i]["img"].ToString();
                goods.detail = dataTable.Rows[i]["detail"].ToString();
                goods.state = Convert.ToInt32(dataTable.Rows[i]["state"]);
                goods.addtime = DateTime.Parse(dataTable.Rows[i]["addtime"].ToString());
                list.Add(goods);
            }
            return list;
        }
        public static List<BSModel.Goods> OnlineGoodsList()
        {
            string strsql = "select * from t_goods where state=1 order by id";
            DataTable dataTable = BSUtility.MsSqlHelper.Query(strsql).Tables[0];
            return DtToList(dataTable);
        }
        public static List<BSModel.Goods> GoodsList()
        {
            string strsql = "select * from t_goods order by id";
            DataTable dataTable = BSUtility.MsSqlHelper.Query(strsql).Tables[0];
            return DtToList(dataTable);
        }
        public static BSModel.Goods GetGoods(int id)
        {
            string strsql = "select * from t_goods where id="+ id +"";
            DataTable dataTable = BSUtility.MsSqlHelper.Query(strsql).Tables[0];
            List<BSModel.Goods> list = DtToList(dataTable);
            return list[0];
        }
    }
}
