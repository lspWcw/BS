using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BSModel
{
    public class Shopping
    {
        public int id { get; set; }
        /// <summary>
        /// 商品
        /// </summary>
        public Goods goods { get; set; }
        /// <summary>
        /// 用户
        /// </summary>
        public Users user { get; set; }
        /// <summary>
        /// 关联用户订单
        /// </summary>
        public BSModel.Order order { get; set; }
        /// <summary>
        /// 数量
        /// </summary>
        public int num { get; set; }
        /// <summary>
        /// 状态
        /// </summary>
        public int state { get; set; }
        /// <summary>
        /// 时间
        /// </summary>
        public DateTime addtime { get; set; }
    }
}
