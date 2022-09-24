using System.Collections;
using System.Runtime.CompilerServices;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("                               %  #%%%%%%%%%%%/ .%                              \r\n                              &&%%%%%%%%%%%%%%%%%%(                             \r\n                              &%%%%%%%%%%%%%%%%%%%(                             \r\n                              &%%%%%%%%%%%%%%%%%%%(                             \r\n                           /&&%%%%.           ,%%%(&%.                          \r\n                              &(%              *%%(                             \r\n                              %/ %(           %/ %(                             \r\n                              %/  ,%%%%%%%%%%%   %(                             \r\n                              %/   %%%%%%%%%%#   %(                             \r\n                              %/   %%%%%%%%%%#   %(                             \r\n                              %/ .%  .,//*,  #%  %(                             \r\n                              %%%              *%%(                             \r\n                              &%%%%%%%%%%%%%%%%%%%(                             \r\n                              &%%%%%%%%%%%%%%%%%%%(                             \r\n                               %%&&%&%%%%%%%%%&%&#");
            race();

        }

        public static void race()
        {
            Random rnd = new Random();

            List<int> list = new List<int>();
            int posicaoPista = (Console.WindowWidth - 20) / 2;
            int timer = 1000;

            initial(list, posicaoPista);

            string pista = "|                    |";

            while (true)
            {
                System.Threading.Thread.Sleep(timer);

                Console.Clear();

                for (int i = 0; i < list.Count ; i++)
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