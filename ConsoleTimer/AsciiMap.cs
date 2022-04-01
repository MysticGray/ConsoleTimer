using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleTimer
{
     public class AsciiMap
    {
        public static string GetAciiText(string character)
        {
            string output = "";
            switch (character)
            {
                case "1":
                    output = @"
 db 
o88 
 88 
 88 
 88 
 VP 
";
                    break;
                case "2":
                    output = @"
.d888b. 
VP  `8D 
   odD' 
 .88'   
j88.    
888888D 
";
                    break;
            }
            return output;

        }
    }
}
