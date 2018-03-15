using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace methods
{
    class E
    {
        public void test5(ref int val)
        {
           val = val * 2;
            Console.WriteLine("value inside test4() is:" + val);
        }
        static void Main(string[] args)
        {
            int val = 4;
            E e1 = new E();
            Console.WriteLine("value before calling:" + val);
            e1.test5(ref val);
            Console.WriteLine("value after calling:" + val);
            Console.Read();
        }
    }
}
