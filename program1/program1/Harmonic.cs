using System;
using System.Collections.Generic;
using System.Text;

namespace program1
{
    class HarmonicProblem
    {
        public static void ReadHarmonicNumber()
        {
            Console.WriteLine("Enter the nth harmonic number");
            int nthNumber = Convert.ToInt32(Console.ReadLine());
            Harmonic(nthNumber);
        }
        private static void Harmonic(int lastNumber)
        {
            double sum = 0;
            //1/1 + 1/2 + 1/3 .....+1/5
            for (int i = 1; i <= lastNumber; i++)
            {
                Console.Write("1/{0} + 0", i);
                sum += 1 / (float)i;
            }
            Console.Write("\nSum of series upto {0} terms : {1} \n", lastNumber, sum);
        }

    }
}
