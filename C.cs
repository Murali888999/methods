using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace methods
{
    class C
    {
        public String test3(String d)
        {
            return d;
        }
        static void Main(string[] args)
        {
            C c1 = new C();
            String d =c1.test3("murali");
            Console.WriteLine("mohan" +d);
        }
    }
}
