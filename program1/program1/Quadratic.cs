using System;
using System.Collections.Generic;
using System.Text;

namespace program1
{
    class Quadratic
    {
        public static void ReadQuadratic()
        {
            Console.WriteLine("Enter the value of a: ");
            string aval = Console.ReadLine();
            int a = Convert.ToInt32(aval);

            Console.WriteLine("Enter the value of b: ");
            string bval = Console.ReadLine();
            int b = Convert.ToInt32(bval);

            Console.WriteLine("Enter the value of c: ");
            string cval = Console.ReadLine();
            int c = Convert.ToInt32(cval);

            double delta = b * b - 4 * a * c;
            Console.WriteLine($"The value of delta is {delta}");

            if (delta<0)
            {
                Console.WriteLine("Roots are imaginary");
            }
            else if (delta == 0)
            {
                Console.WriteLine($"Roots are equal and the value is {-b/2*a}");
            }
            else
            {
                double r1 = ((-b + Math.Sqrt(delta)) / 2 * a);
                double r2 = ((-b - Math.Sqrt(delta)) / 2 * a);
                Console.WriteLine($"roots are real and the values are {r1} and {r2}");
            }

        }
    }
}
