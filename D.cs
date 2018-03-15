using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace methods
{
    class D
    {
        public void test4(int val)
        {
            val = val * 2;
            Console.WriteLine("value inside test4() is:" + val);
        }
        static void Main(string[] args)
        {
            int val = 4;
            D d1 = new D();
            Console.WriteLine("value before calling:" + val);
            d1.test4(val);
            Console.WriteLine("value after calling:" + val);
            Console.Read();
        }
    }
}
