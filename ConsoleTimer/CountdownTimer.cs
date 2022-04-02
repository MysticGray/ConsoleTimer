using System;
using System.Collections.Generic;
using System.Text;
using System.Timers;

namespace ConsoleTimer
{
    public class CountdownTimer
    {
       
        private static DateTime _endTime { get; set; }
        private static Timer _timer { get; set; }
        private static TimeSpan _timeRemaining { get; set; }
        public CountdownTimer(int secondsToRun, int timeInMs = 20)
        {
            _endTime = DateTime.Now.AddSeconds(secondsToRun);
            _timer = new Timer(timeInMs);
        }

        public void CountDown(TimerApp app)
        {
            // Create a timer with a two second interval.
           
            // Hook up the Elapsed event for the timer. 
            _timer.Elapsed += CountDownEvent;
            _timer.AutoReset = true;
            _timer.Enabled = true;
            
            while (_timeRemaining.TotalMilliseconds > -1)
            {

            }
            TimerFinished();
           // if (app.RestartMenu())
          //  {
           //     app.Run();
           // };


        }

        private static void CountDownEvent(Object source, ElapsedEventArgs e)
        {


            _timeRemaining = _endTime.Subtract(e.SignalTime);

            if (_timeRemaining.TotalSeconds < 5)
            {
                Console.ForegroundColor = ConsoleColor.DarkYellow;
            }

            // Console.WriteLine(timeRemaining);
            // Console.Write($"\r\rTotal Seconds left: {timeRemaining.TotalSeconds}");

            Console.Write("\rTime left: {0:HH:mm:ss.fff} ", _timeRemaining.ToString());
            if (_timeRemaining.TotalMilliseconds < 0)
            {
                _timer.Stop();
                _timer.Dispose();
                TimerFinished();
            }
        }

        private static void TimerFinished()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write($"\r\rTimer finished 00:00:00:00000");
            Console.ResetColor();

        }


        private static void OnTimerFinishedEvent(object source, ElapsedEventArgs e)
        {
            Console.Write($"\r\rTimer finished 00:00:00:000");
        }
        private static void ClearScreenEvent(object source, ElapsedEventArgs e)
        {
            Console.Clear();
        }
        private static void OnTimedEvent(Object source, ElapsedEventArgs e)
        {

            if (e.SignalTime.Hour == 0
                && e.SignalTime.Minute == 0
                && e.SignalTime.Second < 5)
            {
                Console.ForegroundColor = ConsoleColor.DarkYellow;
            }
            Console.Write("\rThe Elapsed event was raised at {0:HH:mm:ss.fff}",
                              e.SignalTime);
        }

    }
}
