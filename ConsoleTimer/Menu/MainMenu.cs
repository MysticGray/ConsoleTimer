using System;
using System.Collections.Generic;
using System.Text;
using static System.Console;
namespace ConsoleTimer
{
    class MainMenu : IntMenuBase
    { 
     
        public MainMenu(string title, string prompt) : base(title, prompt)
        {            
         
        }

        public override void Run()
        {
            DisplayMainMenu();
        }
        public void DisplayMainMenu()
        {
            Clear();
            WriteLine(_title);
            WriteLine("The application started at {0:HH:mm:ss.fff}", DateTime.Now);
            Console.WriteLine(_getIntegerPrompt);
            SetChoice(Int32.Parse(Console.ReadLine()));
        }

        private void SetChoice(int integer) 
        {
            _integerResponse = integer;

        }
    }
}
