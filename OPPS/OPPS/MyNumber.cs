using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OPPS
{
    internal class MyNumber
    {
        int a;
         public MyNumber() { this.a = 0; }
        public MyNumber(int a)
        {
            this.a = a;
        }

        public Boolean isPositive()
        { if (this.a < 0)
          return false;
        else 
                return true;   
        }

        public Boolean isNegative()
        {
            if (this.a < 0)
                return true;
            else
                return false;
        }
        public Boolean isZero()
        {
            if (this.a == 0)
                return true;
            else
                return false;
        }
        public Boolean isOdd()
        {
            if (this.a % 2 == 1)
                return true;
            else
                return false;
        }
        public Boolean isEven()
        {
            if (this.a % 2 == 0)
                return true;
            else
                return false;
        }

    }
}
