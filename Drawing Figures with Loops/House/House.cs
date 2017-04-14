using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace House
{
    class House
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var stars = 1;
            if (n % 2 == 0)
                stars++;
            for (int i = 0; i < (n + 1) / 2; i++)
            {
                var padding = ((n - stars) / 2);
                Console.Write(new string('-', padding));
                Console.Write(new string('*', stars));
                Console.WriteLine(new string('-', padding));
                stars = stars + 2;
            }
            for (int i = 0; i < n / 2; i++)
            {
                Console.WriteLine("|" + new string('*', n - 2) + "|");  //kogato nqmame intervali
                
                //Console.Write("|");                                   //kogato imame intervali, izpolzvame vlojeni cikli  
                //var mid = n - 2;
                //for (int c = 0; c < mid; c++)
                //{
                //    Console.Write("*");
                //}
                //Console.WriteLine("|");
            }
        }
    }
}
