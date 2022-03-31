using System;
using System.Collections.Generic;
using System.Text;
using System.Timers;

namespace ConsoleTimer
{
    class Timer
    {

        private static System.Timers.Timer _timer;

        public static void CreateTimer(int timeInMS)
        {
            // Create a timer with a two second interval.
            _timer = new System.Timers.Timer(timeInMS);
            // Hook up the Elapsed event for the timer. 
            _timer.Elapsed += OnTimedEvent;
            _timer.AutoReset = true;
            _timer.Enabled = true;
        }

        private static void OnTimedEvent(Object source, ElapsedEventArgs e)
        {
            Console.WriteLine("The Elapsed event was raised at {0:HH:mm:ss.fff}",
                              e.SignalTime);
        }


    }
}
