using System;

namespace demo
{
    class Data
    {
        public void bishal()
        {
            Console.WriteLine("Hi. I am Bishal...");
        }

        internal void Nick()
        {
            Console.WriteLine("Hi. I am Nick...");
        }
    }
    class Program
    {
    
        static void Main(string[] args)
        {
            Data obj = new Data();
            obj.bishal();
            obj.Nick();


        }
    }
}
