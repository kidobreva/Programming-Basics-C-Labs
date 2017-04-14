using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Perfect_Diamond_1
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                Console.Write(new string(' ', n - 1 - i));
                Console.Write("*");
                for (int j = n - 1; j < n - 1 + i; j++)
                {
                    Console.Write("-*");
                }
                Console.WriteLine();
            }
            for (int i = 0; i < n - 1; i++)
            {
                Console.Write(new string(' ', i + 1));
                Console.Write("*");
                for (int j = n - 2; j > i; j--)
                {
                    Console.Write("-*");
                }
                Console.WriteLine();
            }
        }
    }
}
