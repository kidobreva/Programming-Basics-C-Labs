using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cinema
{
    class Cinema
    {
        static void Main(string[] args)
        {
            var typeFilm = Console.ReadLine();
            var rows = int.Parse(Console.ReadLine());
            var columns = int.Parse(Console.ReadLine());
            var price = 0.0;

            if (typeFilm == "Premiere") price = 12;
            else if (typeFilm == "Normal") price = 7.50;
            else if (typeFilm == "Discount") price = 5.00;
            
            Console.WriteLine("{0:f2} leva", price * rows * columns);
        }
    }
}
