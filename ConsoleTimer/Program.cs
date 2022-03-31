using System;
using System.Timers;

namespace ConsoleTimer
{
    class Program
    {
        static void Main(string[] args)
        {
            Run();
            Console.ReadLine();
            
        }
        private static void Run()
        {
            Console.WriteLine("The application started at {0:HH:mm:ss.fff}", DateTime.Now);
            Console.WriteLine("\nHow many seconds?...\n");
            int seconds = Int32.Parse(Console.ReadLine());
            Console.Clear();
            CountdownTimer countDown = new CountdownTimer(seconds);
            countDown.CountDown();

        }

       
    }
}
