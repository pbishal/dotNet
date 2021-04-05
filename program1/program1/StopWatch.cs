 using System;
using System.Collections.Generic;
using System.Text;
using System.Diagnostics;
using System.Threading;

namespace program1
{
    class Qn1StopWatch
    {
        public static void ReadStopWatch()
        { 
            Stopwatch stopWatch = new Stopwatch();
            Console.WriteLine("Press any key to start the stop watch");
            String userInput = Console.ReadLine();
            if (userInput != null)
            {
                stopWatch.Start();
            }
            Console.WriteLine("Press any key to stop the stop watch");
            userInput = Console.ReadLine();
            if (userInput != null)
            {
                stopWatch.Stop();
            }     
            Console.WriteLine($"Time elapsed: {stopWatch.Elapsed}");
        }
    }
}
