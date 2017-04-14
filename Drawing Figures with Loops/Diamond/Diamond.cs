using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diamond
{
    class Diamond
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var leftRight = (n - 1) / 2;
                        
            {
                for (int i = 1; i <= (n - 1) / 2; i++)
                { // Draw the top part

                    Console.Write(new string('-', leftRight));
                    Console.Write("*");
                    var mid = n - 2 * leftRight - 2;
                    if (mid >= 0)
                    {
                        Console.Write(new string('-', mid));
                        Console.Write("*");
                    }
                    Console.WriteLine(new string('-', leftRight));
                    leftRight--;
                }
                //Console.Write("*");
                //Console.Write(new string('-', n - 2));
                //Console.WriteLine("*");

                for (int i = n / 2; i < n; i++)
                {
                    
                    Console.Write(new string('-', leftRight));
                    Console.Write("*");
                    var mid = n - 2 * leftRight - 2;
                    if (mid >= 0)
                    {
                        Console.Write(new string('-', mid));
                        Console.Write("*");
                    }
                    Console.WriteLine(new string('-', leftRight));
                    leftRight++;
                }
            }
           // for (int i = 0; i < 1; i++)
                //Console.WriteLine("*", n);
        }
    }
}
