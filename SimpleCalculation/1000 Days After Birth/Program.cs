using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1000_Days_After_Birth
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            var date = DateTime.ParseExact(input, "dd-MM-yyyy", null);
            var d2 = date.AddDays(999);
            Console.WriteLine(d2.ToString("dd-MM-yyyy"));
        }
    }
}
