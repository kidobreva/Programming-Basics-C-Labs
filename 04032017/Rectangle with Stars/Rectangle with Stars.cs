using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rectangle_with_Stars
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int n1 = n + 1;

            if (!(n % 2 == 0)) n1 = n1 + 1;
            string firstLastRow = new string('%', 2 * n);
            Console.WriteLine(firstLastRow);

            for (int i = 1; i <= n1 - 2; i++)
            {
                Console.Write("%");
                Console.Write(new string(' ', (((2 * n) - 4)) / 2));
                if (i == (n1 / 2))
                    Console.Write("**");
                else
                    Console.Write("  ");
                Console.Write(new string(' ', (((2 * n) - 4)) / 2));
                Console.WriteLine("%");
            }
            Console.WriteLine(firstLastRow);

            //int n = int.Parse(Console.ReadLine());
            //Console.WriteLine(new string('%', 2 * n));

            //if (n % 2 == 0)
            //    for (int i = 1; i <= n - 1; i++)
            //    {
            //        Console.Write("%");

            //    }
        }
    }
}
