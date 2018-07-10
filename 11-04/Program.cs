using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_04
{
    class Program
    {
        static void Main(string[] args)
        {
            var zodis = "";
            var ssss = "";
            while (zodis != "exit")
            {
                Console.WriteLine("iveskite zodi arba exit");
                zodis = Console.ReadLine();
                if (zodis != "exit")
                {
                    ssss = ssss + zodis;
                }
                  
            }
            Console.WriteLine(ssss);
            Console.ReadKey();
        }
    }
}
