using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Number_Table
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            //var num = 1;
            for (var row = 0; row < n; row++)
            {
                for (var col = 0; col < n; col++)
                {
                    var num = row + col + 1;
                    if (num > n) num = 2 * n - num;
                    Console.Write(num + " ");
                                       
                }
                Console.WriteLine();
            }
        }
    }
}
