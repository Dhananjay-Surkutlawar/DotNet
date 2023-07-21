using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OPPS
{
    internal class Math

    {
        public Math() { }
        // for use of method overloading 
        public void add(int a, int b)
        {
            Console.WriteLine(a +b);
        }
        public void add(int a, int b,int c)
        {
            Console.WriteLine(a + b+c);
        }
        public void add(int a, int b,int c,int d)
        {
            Console.WriteLine(a + b+c+d);
        }
        public void add(float a, float  b)
        {
            Console.WriteLine(a + b);
        }
        public void add(double a, double b)
        {
            Console.WriteLine(a + b);
        }
    }
}
