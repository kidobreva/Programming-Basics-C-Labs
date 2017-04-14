using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Time___15_Minutes
{
    class Program
    {
        static void Main(string[] args)
        {
            var hours = int.Parse(Console.ReadLine());
            var mins = int.Parse(Console.ReadLine()) + 15;
            string zero = "";

            if (mins > 59)
            {
                hours += 1;
                mins -= 60;
            }

            if (mins < 10)
            {  
            
                zero = "0";
            }

            else if (mins == 60)
            { mins = 0; }

           if (hours == 24)

            { hours = 0; }


            Console.WriteLine("{0}:{1}{2}", hours, zero, mins);

            //Console.WriteLine("{0}:{1}{2}", hours % 24, zero, mins % 60);


        }
    }
}



//        static void Main(string[] args)
//        {
//            var hour = int.Parse(Console.ReadLine());
//            var minutes = int.Parse(Console.ReadLine());
//            var newminutes = (minutes + 15);
//            if (newminutes >= 60)
//            {
//                hour = hour + 1;
//                newminutes = newminutes - 60;
//            }

//            if (hour == 24)
//            {
//                Console.WriteLine("0" + ":" + newminutes.ToString("00"));
//            }
//            else Console.WriteLine(hour + ":" + newminutes.ToString("00"));
//        }
//    }
//}
