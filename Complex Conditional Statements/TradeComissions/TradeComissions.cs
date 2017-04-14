using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TradeComissions
{
    class TradeComissions
    {
        static void Main(string[] args)
        {
            var town = Console.ReadLine().ToLower();
            var s = double.Parse(Console.ReadLine());
            var comissions = -1.0;

            if (town == "sofia")
            {
                if (s >= 0 && s <= 500) comissions = 0.05;
                else if (s > 500 && s <= 1000) comissions = 0.07;
                else if (s > 1000 && s <= 10000) comissions = 0.08;
                else if (s > 10000) comissions = 0.12;
            }
            else if (town == "varna")
            {
                if (s >= 0 && s <= 500) comissions = 0.045;
                else if (s > 500 && s <= 1000) comissions = 0.075;
                else if (s > 1000 && s <= 10000) comissions = 0.10;
                else if (s > 10000) comissions = 0.13;
            }
            else if (town == "plovdiv")
            {
                if (s >= 0 && s <= 500) comissions = 0.055;
                else if (s > 500 && s <= 1000) comissions = 0.08;
                else if (s > 1000 && s <= 10000) comissions = 0.12;
                else if (s > 10000) comissions = 0.145;
            }
            if (comissions >= 0)
                Console.WriteLine("{0:f2}", comissions * s);
            else
                Console.WriteLine("error");
        }
    }
}
