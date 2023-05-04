using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FibonacheSerise
{
    public class CreateStopWatch
    {
        public void StopWatch()
        {
            Console.WriteLine("Press any key to start the stopwatch.");
            Console.ReadKey();

            DateTime startTime = DateTime.Now;

            Console.WriteLine("Press any key to stop the stopwatch.");
            Console.ReadKey();

            DateTime endTime = DateTime.Now;

            TimeSpan elapsedTime = endTime - startTime;

            Console.WriteLine("Elapsed time: " + elapsedTime);
        }
    }
}
