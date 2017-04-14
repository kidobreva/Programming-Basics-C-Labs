using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnterName
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your First name: ");
            var firstName = Console.ReadLine();
            Console.Write("Enter your Second name: ");
            var secondName = Console.ReadLine();
            Console.WriteLine($"Hello, {firstName} {secondName}!");
        }
    }
}
