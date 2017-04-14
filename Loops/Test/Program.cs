using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            var i = 0;
            //Console.WriteLine(i++);
            //Console.WriteLine("{0}", i++);
            //Console.WriteLine("{0} {0}", i++);
            //Console.WriteLine("{0} {1}", i++, i++);
            //Console.WriteLine(++i);
            Console.WriteLine("{0} {1}", ++i, i++);
            Console.WriteLine(i);
        }
    }
}
