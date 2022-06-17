using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BSModel
{
    public class Order
    {
        public string id { get; set; }
        public BSModel.Users user { get; set; }
        public int amount { get; set; }
        public int state { get; set; }
        public DateTime addtime { get; set; }
    }
}
