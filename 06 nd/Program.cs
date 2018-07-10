using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_nd
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ivesk skaiciu:");
            var x = Convert.ToInt32(Console.ReadLine());
            if (x >= 0)
                Console.WriteLine("teigiamas");
            else
                Console.WriteLine("neigiamas");

            Console.ReadLine();
        }
    }
}
    
