using System;
using System.Collections.Generic;
using System.Text;

namespace program1
{
    class WindChill
    {
        public static void ReadWindChill()
        {
            Console.WriteLine("Enter the value of t: ");
            string tval = Console.ReadLine();
            int t = Convert.ToInt32(tval);

            Console.WriteLine("Enter the value of v: ");
            string vval = Console.ReadLine();
            int v = Convert.ToInt32(vval);

            if(t > 50 || v > 120 || v < 3)
            {
                Console.WriteLine("Enter a valid input");
            }
            else
            {
                double w = 35.74 + 0.6215 * t + (0.4275 * t - 35.75) * (Math.Pow(v, 0.16));
                Console.WriteLine($"the value WindChill is {w}");
            }
        }
    }
}
