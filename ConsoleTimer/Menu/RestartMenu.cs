using System;
using System.Collections.Generic;
using System.Text;
using static System.Console;
namespace ConsoleTimer
{
    class RestartMenu
    {
        private static string[] _confirmOptions;
        private int _selectedIndex;
        private string _mainMenuTitle;
        public RestartMenu()
        {
            _mainMenuTitle = "Restart?\n";
            _selectedIndex = 0;
            _confirmOptions = new string[] { "Y", "N" };
        }
        private void Display()
        {
            WriteLine(_mainMenuTitle);
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
                }
                else
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
           // ConsoleKeyInfo keyPress = ReadKey();
        }
        public bool GetOption() 
        {
            ConsoleKey keyPressed;
            do
            {
                Clear();
                Display();
                ConsoleKeyInfo keyInfo = ReadKey(true);
                keyPressed = keyInfo.Key;
                if (keyPressed == ConsoleKey.UpArrow)
                {
                    _selectedIndex--;
                    if (_selectedIndex == -1)
                    {
                        _selectedIndex = _confirmOptions.Length - 1;
                    }
                    
                    
                }
                if (keyPressed == ConsoleKey.DownArrow)
                {
                    _selectedIndex++;
                    if (_selectedIndex > _confirmOptions.Length - 1) 
                    {
                        _selectedIndex = 0;
                    }
                    
                }
            } while (keyPressed != ConsoleKey.Enter);

            if (_selectedIndex == 0)
            {
                return true;
            } else
            {
                return false;
            }
        }
    }
}
