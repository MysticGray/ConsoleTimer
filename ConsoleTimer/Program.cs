using System;
using System.Timers;

namespace ConsoleTimer
{
    class Program
    {
        static void Main(string[] args)
        {
            ConsoleHelper.SetCurrentFont("Consolas", 32);
            //Console.Write(AsciiMap.GetAciiText("2"));
            TimerApp app = new TimerApp();
            app.Run();
            Console.ReadKey(true);
        }      
    }
}
