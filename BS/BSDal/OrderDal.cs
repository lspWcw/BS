using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace BSDal
{
    public class OrderDal
    {
        public static bool Add(BSModel.Order order)
        {
            bool result = false;
            string strsql = "insert into t_order (id,userid,amount,state,addtime)values('" + order.id + "','" + order.user.id + "','" + order.amount + "','" + order.state + "','" + order.addtime + "')";
            int i = BSUtility.MsSqlHelper.ExecuteSql(strsql);
            if (i > 0)
            {
                return true;
            }
            return result;
        }
        public static List<BSModel.Order> DtToList(DataTable dataTable)
        {
            List<BSModel.Order> list = new List<BSModel.Order>();
            for (int i = 0; i < dataTable.Rows.Count; i++)
            {
                BSModel.Order order = new BSModel.Order();
                order.id = dataTable.Rows[i]["id"].ToString();
                BSModel.Users user1 = BSDal.UsersDal.GetUser(int.Parse(dataTable.Rows[i]["userid"].ToString()));
                order.user = user1;
                order.amount = int.Parse(dataTable.Rows[i]["amount"].ToString());
                order.state = int.Parse(dataTable.Rows[i]["state"].ToString());
                order.addtime = DateTime.Parse(dataTable.Rows[i]["addtime"].ToString());
                list.Add(order);
            }
            return list;
        }
        public static List<BSModel.Order> OrderList(int userid)
        {
            string strsql = "select * from t_order where userid = " + userid + " order by addtime desc";
            DataTable dataTable = BSUtility.MsSqlHelper.Query(strsql).Tables[0];
            return DtToList(dataTable);
        }
        public static List<BSModel.Order> OrderList()
        {
            string strsql = "select * from t_order order by addtime desc";
            DataTable dataTable = BSUtility.MsSqlHelper.Query(strsql).Tables[0];
            return DtToList(dataTable);
        }
        public static bool UpOrder(string orderid, int state)
        {
            bool result = false;
            string strsql = "update t_order set state = " + state + " where id='" + orderid + "'";
            int i = BSUtility.MsSqlHelper.ExecuteSql(strsql);
            if (i > 0)
            {
                return true;
            }
            return result;
        }
    }
}
