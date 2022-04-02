using System;
using System.Collections.Generic;
using System.Text;
using static System.Console;
namespace ConsoleTimer
{
    public class RestartMenu : MultiChoiceMenuBase
    {
        //private static string[] _options;
        //private int _selectedIndex;
        //private string _menuTitle;
        public RestartMenu(string[] options, string title) : base(options, title)
        {

        }
        public override void Run ()
        {
            Display();
        }
        private void Display()
        {
            WriteLine(_menuTitle);
            for (int i = 0; i < _options.Length; i++)
            {
                string currentOptions = _options[i];
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
                        _selectedIndex = _options.Length - 1;
                    }
                    
                    
                }
                if (keyPressed == ConsoleKey.DownArrow)
                {
                    _selectedIndex++;
                    if (_selectedIndex > _options.Length - 1) 
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
