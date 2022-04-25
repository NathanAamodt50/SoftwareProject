using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JackrabbitPromotionSoftware
{
    public class Value
    {
        public int Val { get; set; }

        public Value(int v = 0)
        {
            Val = v;
        }
        public Value(Value W)
        {
            Val = W.Val;
        }
    }
}
