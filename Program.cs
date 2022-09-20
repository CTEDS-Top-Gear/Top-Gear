﻿using Figgle;

namespace TopGear
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PresentationMenu();
            bool playGame = OptionsMenu();
            if (playGame)
            {
                // call PlayGame function
            }
        }

        static void PresentationMenu() 
        {
            Console.WriteLine(FiggleFonts.Computer.Render("                  Top Gear"));

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(
            "                                                  _.-=\"_-         _\r\n" +
            "                                           _.-=\"   _-          | ||\"\"\"\"\"\"\"---._______     __..\r\n" +
            "                               ___.===\"\"\"\"-.______-,,,,,,,,,,,,`-''----\" \"\"\"\"\"       \"\"\"\"\"  __'\r\n" +
            "                        __.--\"\"     __        ,'                   o \\           __        [__|\r\n" +
            "                   __-\"\"=======.--\"\"  \"\"--.=================================.--\"\"  \"\"--.=======:\r\n" +
            "                  ]       [w] : /        \\ : |========================|    : /        \\ :  [w] :\r\n" +
            "                  V___________:|          |: |========================|    :|          |:   _-\"\r\n" +
            "                   V__________: \\        / :_|=======================/_____: \\        / :__-\"\r\n" +
            "                   -----------'  \"-____-\"  `-------------------------------'  \"-____-\"");
            Console.ResetColor();
            
            Console.WriteLine("-----------------------------------------------------------------------------------------------------------------------");
            string s = "Press any button to start";
            Console.SetCursorPosition((Console.WindowWidth - s.Length) / 2, Console.CursorTop);
            Console.WriteLine(s);
            Console.WriteLine("-----------------------------------------------------------------------------------------------------------------------");

            Console.ReadKey();
            Console.Clear();
        }

        static bool OptionsMenu()
        {
            bool playGame = false;

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
            bool exitMenu = false;

            do
            {
                consoleKeyInfo = Print(options, currentOption);

                if (consoleKeyInfo.Key == ConsoleKey.DownArrow)
                {
                    currentOption++;
                    if (currentOption < 0) currentOption = 0;
                    if (currentOption >= options.Count) currentOption = options.Count - 1;
                }
                else if (consoleKeyInfo.Key == ConsoleKey.UpArrow)
                {
                    currentOption--;
                    if (currentOption < 0) currentOption = 0;
                    if (currentOption >= options.Count) currentOption = options.Count - 1;
                }
                else if (options[currentOption] == "Start game")
                {
                    if (consoleKeyInfo.Key == ConsoleKey.Enter)
                    {
                        playGame = true;
                        exitMenu = true;
                    }
                }
                else if (options[currentOption].Contains("Name: "))
                {
                    if (consoleKeyInfo.Key == ConsoleKey.Backspace)
                    {
                        // Remove 1 caracter from name
                        if (options[currentOption] != "Name: ")
                        {
                            options[currentOption] = options[currentOption].Substring(0, options[currentOption].Length - 1);
                        }
                    }
                    else
                    {
                        // Add key read to name
                        options[currentOption] += consoleKeyInfo.KeyChar;
                    }
                }
                else if (options[currentOption].Contains("Track: "))
                {
                    if (consoleKeyInfo.Key == ConsoleKey.RightArrow)
                    {
                        currentTrack++;
                        if (currentTrack < 0) currentTrack = tracks.Count - 1;
                        if (currentTrack >= tracks.Count) currentTrack = 0;
                        options[2] = tracks[currentTrack];
                    }
                    else if (consoleKeyInfo.Key == ConsoleKey.LeftArrow)
                    {
                        currentTrack--;
                        if (currentTrack < 0) currentTrack = 0;
                        if (currentTrack >= tracks.Count) currentTrack = tracks.Count - 1;
                        options[2] = tracks[currentTrack];
                    }
                }
                else if (options[currentOption] == "Exit")
                {
                    if(consoleKeyInfo.Key == ConsoleKey.Enter)
                    {
                        exitMenu = true;
                    }
                }

                Console.Clear();

            } while (!exitMenu);

            return playGame;
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