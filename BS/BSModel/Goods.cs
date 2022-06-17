using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BSModel
{
    public class Goods
    {
        public int id { get; set; }
        public string title { get; set; }
        public int price { get; set; }
        public int num { get; set; }
        public string img { get; set; }
        public string detail { get; set; }
        public int state { get; set; }
        public DateTime addtime { get; set; }
    }
}
