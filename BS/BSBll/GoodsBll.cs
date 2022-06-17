using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BSBll
{
    public class GoodsBll
    {
        public static bool Add(BSModel.Goods goods)
        {
            return BSDal.GoodsDal.Add(goods);
        }
        public static List<BSModel.Goods> OnlineGoodsList()
        {
            return BSDal.GoodsDal.OnlineGoodsList();
        }
        public static List<BSModel.Goods> GoodsList()
        {
            return BSDal.GoodsDal.GoodsList();
        }
        public static BSModel.Goods GetGoods(int id)
        {
            return BSDal.GoodsDal.GetGoods(id);
        }
        public static bool UpGoods(BSModel.Goods goods)
        {
            return BSDal.GoodsDal.UpGoods(goods);
        }
    }
}
