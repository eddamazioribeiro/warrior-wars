using System;

namespace WarriorWars.Utils
{
    static class  Utilities
    {
        public static void ColorfulConsoleText(string text, ConsoleColor color)
        {
            Console.ForegroundColor = color;
            System.Console.WriteLine(text);
            Console.ResetColor();

        }
    }

}