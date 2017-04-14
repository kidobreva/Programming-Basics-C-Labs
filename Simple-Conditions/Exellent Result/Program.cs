using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exellent_Result
{
    class Program
    {
        static void Main(string[] args)
        {
            //int a = 7;
            //int b = 11;
            //int c = 3;

            ////bool result = !(a > b);  //! - ne e li vqrno, che a>b
            //bool result = (a < b);
            //Console.WriteLine(result);

            //var first = "first";
            //var second = "second";

            ////if (!(first != second))
            //if ((first != second))
            //{
            //    Console.WriteLine("This is TRUE");
            //    Console.WriteLine(first);
            //}

            var grade = double.Parse(Console.ReadLine());
            if (grade >= 5.50)
            {
                Console.WriteLine("Excellent!");
            }

        }
    }
}
