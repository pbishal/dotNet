using System;

namespace calcDemo
{
    class calc
    {
        public void Add(int a, int b)
        {
            int c = a + b;
            Console.WriteLine("Sum of {0} and {1} is {2}", a, b, c);

        }
        static void Main(string[] args)
        {
            int a, b;
            Console.WriteLine("Enter two numbers: ");
            a = Convert.ToInt32(Console.ReadLine());
            b = Convert.ToInt32(Console.ReadLine());
            calc obj = new calc();
            obj.Add(a, b);
        }
    }
}
