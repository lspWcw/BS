using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BSBll
{
    public class ShoppingBll
    {
        public static bool Add(BSModel.Shopping shopping)
        {
            return BSDal.ShoppingDal.Add(shopping);
        }
        public static bool DelShopping(int id)
        {
            return BSDal.ShoppingDal.DelShopping(id);
        }
        public static List<BSModel.Shopping> List(int userid)
        {
            return BSDal.ShoppingDal.List(userid);
        }
        public static List<BSModel.Shopping> ShoppingList(int userid)
        {
            return BSDal.ShoppingDal.ShoppingList(userid);
        }
        public static List<BSModel.Shopping> ShoppingList(string orderid)
        {
            return BSDal.ShoppingDal.ShoppingList(orderid);
        }
        public static List<BSModel.Shopping> ShoppingList(int goodsid, int userid, int state)
        {
            return BSDal.ShoppingDal.ShoppingList(goodsid, userid, state);
        }
        public static bool UpdataNum(int goodsid, int userid, int state)
        {
            return BSDal.ShoppingDal.UpdataNum(goodsid, userid, state);
        }
        public static bool updateShopping(string orderNum, int userid, int state)
        {
            return BSDal.ShoppingDal.updateShopping(orderNum, userid, state);
        }
    }
}
