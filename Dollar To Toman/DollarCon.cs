using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Dollar_To_Toman
{
    public static class DollarCon
    {
        public static int Dollar(this int toman)
        {
            toman = toman * 60000;

            return toman;
        }
    }
}
