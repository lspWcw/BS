using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BSBll
{
    public class OrderBll
    {
        public static bool Add(BSModel.Order order)
        {
            return BSDal.OrderDal.Add(order);
        }
        public static List<BSModel.Order> OrderList()
        {
            return BSDal.OrderDal.OrderList();
        }
        public static List<BSModel.Order> OrderList(int userid)
        {
            return BSDal.OrderDal.OrderList(userid);
        }
        public static bool UpOrder(string orderid, int state)
        {
            return BSDal.OrderDal.UpOrder(orderid, state);
        }
    }
}
