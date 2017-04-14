using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bricks
{
    class Bricks
    {
        static void Main(string[] args)
        {
            var broiTuhli = int.Parse(Console.ReadLine());
            var broiRabotnici = int.Parse(Console.ReadLine());
            var vmestimostKolochka = int.Parse(Console.ReadLine());

            decimal obshtoTuhli = (decimal)broiRabotnici * vmestimostKolochka;
            decimal obshtoKursove = (decimal)broiTuhli / obshtoTuhli;
            Console.WriteLine(Math.Ceiling(obshtoKursove));

        }
    }
}
