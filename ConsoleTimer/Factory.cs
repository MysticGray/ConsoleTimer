using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleTimer
{
    public class Factory
    {
        public static IMultiChoiceMenuBase CreateRestartMenu()
        {
            string[] menuChoices = new string[] { "Y", "N" };
            return new RestartMenu(menuChoices, "Restart Menu");            
        }
        public static IIntMenuBase CreateMainMenu()
        {
            return new MainMenu("Count Down Timer application","How many seconds?");
        }
    }
}
