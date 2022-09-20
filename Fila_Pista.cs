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
            Console.WriteLine("|          |");
            Console.WriteLine("|   |--|   |");
            Console.WriteLine("|          |");
        }

        public static void race()
        {
            ArrayList list = new ArrayList();
            int timer = 1000;

            while (true)
            {

                if (list.Count < 50)
                {
                    line(list);
                }

                System.Threading.Thread.Sleep(timer);

            }

           
        }  

        public static void line(ArrayList a)
        {
            for (int i = 0; i < 10; i++)
            {
                a.Add("|           |");
            }
        }


    }
}