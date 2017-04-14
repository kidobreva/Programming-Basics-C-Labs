using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Greatest_Common_Divisor__CGD_
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = int.Parse(Console.ReadLine());
            var b = int.Parse(Console.ReadLine());

            while (b != 0)
            {
                var oldB = b;
                b = a % b;  // pri tova delenie, ako "a" e po-malko ot "b", to rezzultatyt shte e "a", tyi kato tova e celochisleno delene s ostatyk, a ostatyk nqma
                a = oldB;   // na pyrvata iteraciq si smenqt mestata "a" i "b", ako "a" < "b"

            }
            Console.WriteLine("GCD = {0}", a);
        }
    }
}
