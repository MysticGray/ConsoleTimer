using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleTimer
{
    public class TimerApp
    {
        private int _seconds;
        public TimerApp(int seconds)
        {
            _seconds = seconds;
        }
        public void Run()
        {
                Console.Clear();
                CountdownTimer countDown = new CountdownTimer(_seconds);
                countDown.CountDown(this);       
            
        }
    }
}
