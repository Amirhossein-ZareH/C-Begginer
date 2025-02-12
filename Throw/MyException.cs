using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Throw
{
    internal class MyException:Exception
    {
        public MyException(string str) : base(str)
        {
            
        }
    }
}
