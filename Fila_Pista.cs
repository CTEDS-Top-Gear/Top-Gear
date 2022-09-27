using System;
using System.Collections;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace TopGear
{
    public class Pista
    {

        public static void race()
        {
            Random rnd = new Random();

            List<int> list = new List<int>();
            int posicaoPista = (Console.WindowWidth - 20) / 2;
            int timer = 100;

            initial(list, posicaoPista);

            string pista = "|                    |";
            string car = "[]--o--[]";

            int currentPosition = (Console.WindowWidth - car.Length) / 2;
            ConsoleKeyInfo consoleKeyInfo;
            bool exitGame = false;

            while (true)
            {
                Stopwatch stopwatch = new Stopwatch();
                stopwatch.Start();
                while (stopwatch.ElapsedMilliseconds < timer)
                {
                    if (Program.PrintCar(car, currentPosition))
                    {
                        consoleKeyInfo = Console.ReadKey();

                        if (consoleKeyInfo.Key == ConsoleKey.LeftArrow)
                        {
                            currentPosition--;

                            if (currentPosition < 0)
                            {
                                currentPosition = 0;
                            }
                        }
                        else if (consoleKeyInfo.Key == ConsoleKey.RightArrow)
                        {
                            currentPosition++;

                            if (currentPosition > Console.WindowWidth - car.Length)
                            {
                                currentPosition = Console.WindowWidth - car.Length;
                            }
                        }
                        else if (consoleKeyInfo.Key == ConsoleKey.Escape)
                        {
                            exitGame = true;
                        }

                    }

                    //Console.Clear();
                }

                Console.Clear();

                for (int i = 0; i < list.Count; i++)
                {
                    Console.SetCursorPosition(list[i], Console.CursorTop);
                    Console.WriteLine(pista);
                }


                ImprimePista(list, rnd.Next(3));

            }


        }

        public static void initial(List<int> lista, int racePosition)
        {
            for (int i = 0; i < 10; i++)
            {
                lista.Add(racePosition);
            }
        }

        public static void ImprimePista(List<int> lista, int random)
        {
            int posicao = lista[0];

            if (random == 0)
            {
                lista.RemoveAt(9);
                lista.Insert(0, posicao);
                return;
            }
            else if (random == 1)
            {
                lista.RemoveAt(9);
                lista.Insert(0, posicao + 1);
                return;
            }
            else
            {
                lista.RemoveAt(9);
                lista.Insert(0, posicao - 1);
                return;
            }


        }

    }
}