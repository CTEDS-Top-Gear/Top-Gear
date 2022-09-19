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

            OptionsMenu();

        }

        static void OptionsMenu()
        {
            List<string> tracks = new List<string>();

            tracks.Add("Track: Easy");
            tracks.Add("Track: Medium");
            tracks.Add("Track: Hard");

            int currentTrack = 0;

            List<string> options = new List<string>();

            options.Add("Start game");
            options.Add("Name: ");
            options.Add(tracks[currentTrack]);
            options.Add("Exit");

            int currentOption = 0;

            ConsoleKeyInfo consoleKeyInfo;
            bool exit = false;
            string name = String.Empty;

            do
            {
                consoleKeyInfo = Print(options, currentOption);

                switch (consoleKeyInfo.Key)
                {
                    case ConsoleKey.Enter:
                        if (options[currentOption] == "Exit")
                        {
                            exit = true;
                        }
                        break;

                    case ConsoleKey.DownArrow:
                        currentOption++;
                        break;

                    case ConsoleKey.UpArrow:
                        currentOption--;
                        break;

                    case ConsoleKey.RightArrow:
                        if (options[currentOption].Contains("Track: "))
                        {
                            currentTrack++;
                            if (currentTrack < 0) currentTrack = 0;
                            if (currentTrack >= tracks.Count) currentTrack = tracks.Count - 1;
                            options[2] = tracks[currentTrack];
                        }
                        break;

                    case ConsoleKey.LeftArrow:
                        if (options[currentOption].Contains("Track: "))
                        {
                            currentTrack--;
                            if (currentTrack < 0) currentTrack = 0;
                            if (currentTrack >= tracks.Count) currentTrack = tracks.Count - 1;
                            options[2] = tracks[currentTrack];
                        }
                        break;

                    case ConsoleKey.Backspace:
                        if (options[currentOption].Contains("Name: "))
                        {
                            if (options[currentOption] != "Name: ")
                            {
                                options[currentOption] = options[currentOption].Substring(0, options[currentOption].Length - 1);
                            }
                        }
                        break;

                    default:
                        if (options[currentOption].Contains("Name: "))
                        {
                            options[currentOption] += consoleKeyInfo.KeyChar;
                        }
                        break;
                }

                if (currentOption < 0) currentOption = 0;
                if (currentOption >= options.Count) currentOption = options.Count - 1;

                Console.Clear();
            } while (!exit);
        }

        static ConsoleKeyInfo Print(List<string> options, int currentOption)
        {
            for (int i = 0; i < options.Count; i++)
            {
                if (i == currentOption)
                {
                    Console.Write("->");
                }
                else
                {
                    Console.Write("--");
                }

                Console.WriteLine(options[i]);
            }

            return Console.ReadKey();
        }
    }
}