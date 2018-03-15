using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace methods
{
    class A
    {
        public void M1()
        {
            Console.WriteLine("M1()");
        }
        static void Main(string[] args)
        {
            A obj = new A();
            obj.M1();
            Console.Read();
        }
    }
}
