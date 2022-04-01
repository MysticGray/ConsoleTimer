using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleTimer
{
    public class TimerApp
    {
        private int _seconds;
        public TimerApp()
        {
            
        }
        public void Run()
        {
                MainMenu menu = new MainMenu("Count Down Timer application");
                _seconds = menu.DisplayMainMenu();

                //_seconds = RunRestartMenu();
                Console.Clear();
                CountdownTimer countDown = new CountdownTimer(_seconds);
                countDown.CountDown(this);
        
            // Load Main Menu           
            
        }
        public bool RestartMenu()
        {
            RestartMenu rm = new RestartMenu();
            return rm.GetOption();
        }
    }
}
