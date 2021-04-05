using System;
using System.Collections.Generic;
using System.Text;

namespace program1
{
    class Factorial
    {
        public static void ReadFactorial()
        {
            int i, fact = 1, number;
            Console.Write("Enter the Number: ");
            number = Convert.ToInt32(Console.ReadLine());
            for (i = 2; i <= number; i++)
            {
                fact = fact * i;
            }
            Console.Write($"factorial of {number} is {fact}");
        }
    }
}
