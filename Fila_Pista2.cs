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
            List<int> queue = new List<int>();
            initial(queue, (Console.WindowWidth -10) / 2);

            for (int i = queue.Count - 1; i >= 0; i--)
            {
                Console.WriteLine(queue[i]);
            }

            //foreach (string i in queue)
            //{
            //    Console.WriteLine(i);
            //}

            //int racePosition = (Console.WindowWidth - queue[0].Length) / 2;

            //while (true)
            //{
            //    System.Threading.Thread.Sleep(timer);

            //    Console.Clear();

            //    queue.RemoveAt(9);
            //    queue.Insert(0, "a");

            //    foreach (var item in queue)
            //    {
            //        Console.WriteLine(item);
            //    }
            //}

           
        }  

        public static void initial(List<int> lista, int racePosition)
        {
            for (int i = 0; i < 10; i++)
            {              
                lista.Add(racePosition);
            }
        }

        public static void printTrack()
        {
            while (true)
            {

            }
        }
    }
}