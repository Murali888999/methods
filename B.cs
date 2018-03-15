using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace methods
{
    class B
    {
        public void test1(String s)
        {
            Console.WriteLine("Murali" + s);
        }
        static void Main(string[] args)
        {
            B b1 = new B();
            b1.test1("Mohan");
            Console.Read();
        }
    }
}