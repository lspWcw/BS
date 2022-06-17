using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace BSDal
{
    public class ShoppingDal
    {
        public static bool Add(BSModel.Shopping shopping)
        {
            bool result = false;
            string strsql = "insert into t_shopping (goodsid,userid,orderid,num,state,addtime)values(" + shopping.goods.id + "," + shopping.user.id + ",''," + shopping.num + "," + shopping.state + ",'" + shopping.addtime + "')";
            int i = BSUtility.MsSqlHelper.ExecuteSql(strsql);
            if (i > 0)
            {
                return true;
            }
            return result;
        }

        public static bool DelShopping(int id)
        {
            bool result = false;
            string strsql = "delete from t_shopping where id = " + id + "";
            int i = BSUtility.MsSqlHelper.ExecuteSql(strsql);
            if (i > 0)
            {
                return true;
            }
            return result;
        }
        public static List<BSModel.Shopping> DtToList(DataTable dataTable)
        {
            List<BSModel.Shopping> list = new List<BSModel.Shopping>();
            for (int i = 0; i < dataTable.Rows.Count; i++)
            {
                BSModel.Shopping shopping = new BSModel.Shopping();
                shopping.id = Convert.ToInt32(dataTable.Rows[i]["id"].ToString());
                BSModel.Goods good1 = BSDal.GoodsDal.GetGoods(int.Parse(dataTable.Rows[i]["goodsid"].ToString()));
                shopping.goods = good1;
                BSModel.Users user1 = BSDal.UsersDal.GetUser(int.Parse(dataTable.Rows[i]["userid"].ToString()));
                shopping.user = user1;
                shopping.num = Convert.ToInt32(dataTable.Rows[i]["num"].ToString());
                shopping.state = Convert.ToInt32(dataTable.Rows[i]["state"]);
                shopping.addtime = DateTime.Parse(dataTable.Rows[i]["addtime"].ToString());
                list.Add(shopping);
            }
            return list;
        }
        public static List<BSModel.Shopping> List(int userid)
        {
            string strsql = "select * from t_shopping where userid = "+userid+" and state=1 order by userid";
            DataTable dataTable = BSUtility.MsSqlHelper.Query(strsql).Tables[0];
            return DtToList(dataTable);
        }
        public static List<BSModel.Shopping> ShoppingList(int userid)
        {
            string strsql = "select * from t_shopping where userid = "+userid+" and state=0 order by userid";
            DataTable dataTable = BSUtility.MsSqlHelper.Query(strsql).Tables[0];
            return DtToList(dataTable);
        }
        public static List<BSModel.Shopping> ShoppingList(string orderid)
        {
            string strsql = "select * from t_shopping where orderid = '" + orderid + "' and state=1";
            DataTable dataTable = BSUtility.MsSqlHelper.Query(strsql).Tables[0];
            return DtToList(dataTable);
        }
        public static List<BSModel.Shopping> ShoppingList(int goodsid, int userid,int state)
        {
            string strsql = "select * from t_shopping where goodsid = " + goodsid + " and userid = " + userid + " and state = " + state + "order by id";
            DataTable dataTable = BSUtility.MsSqlHelper.Query(strsql).Tables[0];
            return DtToList(dataTable);
        }
        public static BSModel.Shopping GetShopping(int id)
        {
            string strsql = "select * from t_shopping where id=" + id + "";
            DataTable dataTable = BSUtility.MsSqlHelper.Query(strsql).Tables[0];
            List<BSModel.Shopping> list = DtToList(dataTable);
            return list[0];
        }
        public static bool UpdataNum(int goodsid, int userid, int state)
        {
            bool result = false;
            string strsql = "update t_shopping set num=num+1 where goodsid = " + goodsid + " and userid = " + userid + " and state = " + state + "";
            int i = BSUtility.MsSqlHelper.ExecuteSql(strsql);
            if (i > 0)
            {
                return true;
            }
            return result;
        }
        public static bool updateShopping(string orderNum,int userid, int state)
        {
            bool result = false;
            string strsql = "update t_shopping set orderid=" + orderNum + ",state=1 where userid = " + userid + " and state = " + state + "";
            int i = BSUtility.MsSqlHelper.ExecuteSql(strsql);
            if (i > 0)
            {
                return true;
            }
            return result;
        }
    }
}
