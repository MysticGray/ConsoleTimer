using System;
using System.Collections.Generic;
using System.Text;
using static System.Console;
namespace ConsoleTimer
{
    class MainMenu
    {
        private static string[] _confirmOptions = { "Y", "N" };
        private int _selectedIndex;
        private string _mainMenuTitle;
        public MainMenu(string mainMenuTitle)
        {            
            _mainMenuTitle = mainMenuTitle;
            _selectedIndex = 0;
        }
        public int DisplayMainMenu()
        {
            Clear();
            WriteLine(_mainMenuTitle);
            WriteLine("The application started at {0:HH:mm:ss.fff}", DateTime.Now);
            Console.WriteLine("\nHow many seconds?...\n");
            return Int32.Parse(Console.ReadLine());
        }
        public bool RestartMenu()
        {
            WriteLine("Restart?\n");
            for (int i = 0; i < _confirmOptions.Length; i++)
            {
                string currentOptions = _confirmOptions[i];
                string selectedPrefix;
                string selectedPostfix;
                if (i == _selectedIndex)
                {
                    selectedPrefix = ">>";
                    selectedPostfix = "<<";
                    BackgroundColor = ConsoleColor.White;
                    ForegroundColor = ConsoleColor.Black;
                } else
                {
                    selectedPrefix = "  ";
                    selectedPostfix = "  ";
                    BackgroundColor = ConsoleColor.Black;
                    ForegroundColor = ConsoleColor.White;
                }
                    
                WriteLine($"[ {selectedPrefix} { currentOptions } {selectedPostfix} ]");
            }
            // Resets the console colors 
            ResetColor();
                ConsoleKeyInfo keyPress = ReadKey();
            // if enter on y 
            return true;
        }
    }
}
