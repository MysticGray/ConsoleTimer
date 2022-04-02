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
            // Test Restart menu
           // string[] menuChoices = new string[] { "Y", "N" };
           // RestartMenu rm = new RestartMenu(menuChoices, "Restart Menu");
          //  IMultiChoiceMenuBase restartMenu = Factory.CreateRestartMenu();
          //  restartMenu.Run();
            IIntMenuBase mainMenu = Factory.CreateMainMenu();
            mainMenu.Run();
            TimerApp app = new TimerApp(mainMenu.GetIntegerResponse());
            app.Run();
            //Console.ReadKey(true);
        }      
    }
}
