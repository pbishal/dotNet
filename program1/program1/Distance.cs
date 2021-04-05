using System;
using System.Collections.Generic;
using System.Text;

namespace program1
{
    class Distance
    {
        public static void ReadDistance()
        {
            //int distance;

            Console.WriteLine("Enter the value of x: ");
            string xval = Console.ReadLine();
            int x = Convert.ToInt32(xval);

            Console.WriteLine("Enter the value of y: ");
            string yval = Console.ReadLine();
            int y = Convert.ToInt32(yval);

            double distance = Math.Sqrt(x * x + y * y);
            Console.WriteLine(distance);


        }
    }
}
