using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Password_Guess
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string str = "s3cr3t!P@ssw0rd";

            if (input == str)
            { Console.WriteLine("Welcome"); }

            else
            { Console.WriteLine("Wrong password!"); }
        }
    }
}
