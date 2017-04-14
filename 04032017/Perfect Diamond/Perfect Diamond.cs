using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Perfect_Diamond
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n - 1; i++)           // gorna chast          
            {
                int position = 0;
                for (int j = 0; j < n - 1 - i; j++)
                {
                    Console.Write(" ");
                }
                for (int l = 0; l < 2 * i + 1; l++)
                {
                    position++;
                    if (position % 2 == 0)                 
                    Console.Write("-"); 
                    else
                        Console.Write("*");
                }
                Console.WriteLine();                
            }


                for (int j = 0; j < 2 * n - 1; j++)  // sredna chast
            {
                if (j % 2 == 0)
                Console.Write("*"); 
                else
                    Console.Write("-");
            }
                Console.WriteLine();


            for (int k = 0; k < n - 1; k++)          // dolna chast
            {
                int position = 0;
                for (int m = 0; m < k + 1; m++)
                {
                    Console.Write(" ");
                }
                for (int j = k + 1; j <= 2 * n - 3 - k; j++)
                {
                    position++;
                    if (position % 2 == 0)
                        Console.Write("-");
                    else
                        Console.Write("*");
                }
                Console.WriteLine();
            }
        }
    }
}
