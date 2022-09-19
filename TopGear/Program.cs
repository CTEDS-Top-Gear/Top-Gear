using System;
using Figgle;
namespace TopGear
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string s;
            Console.WriteLine(FiggleFonts.Computer.Render("                  Top Gear"));
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(
                "                                _.-=\"_-         _\r\n                         _.-=\"   _-          | ||\"\"\"\"\"\"\"---._______     __..\r\n             ___.===\"\"\"\"-.______-,,,,,,,,,,,,`-''----\" \"\"\"\"\"       \"\"\"\"\"  __'\r\n      __.--\"\"     __        ,'                   o \\           __        [__|\r\n __-\"\"=======.--\"\"  \"\"--.=================================.--\"\"  \"\"--.=======:\r\n]       [w] : /        \\ : |========================|    : /        \\ :  [w] :\r\nV___________:|          |: |========================|    :|          |:   _-\"\r\n V__________: \\        / :_|=======================/_____: \\        / :__-\"\r\n -----------'  \"-____-\"  `-------------------------------'  \"-____-\""
                );
            Console.ResetColor();
            Console.WriteLine("-----------------------------------------------------------------------------------------------------------------------");
            s = "Press any button to start";
            Console.SetCursorPosition((Console.WindowWidth - s.Length) / 2, Console.CursorTop);
            Console.WriteLine(s);
            Console.WriteLine("-----------------------------------------------------------------------------------------------------------------------");
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine("Jogo iniciou");
        }
    }
}