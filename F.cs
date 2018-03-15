using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace methods
{
    class F
    {
        public void test6(out int val1, out int val2)
        {
            int i = 6;
            val1 = i;
            val2 =i;
            val1 *= val1;
            val2 *= val2;
            Console.WriteLine("inside test6:" + val1, +val2);
        }
        static void Main(string[] args)
        {
            int val1 = 20, val2 = 20;
            F f1 = new F();
            Console.WriteLine("before calling:" + val1, +val2);
            f1.test6(out val1, out val2);
            Console.WriteLine("after calling:" +val1, +val2);
            Console.Read();
        }
    }
}
