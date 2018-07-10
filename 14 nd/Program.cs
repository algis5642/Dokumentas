using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14_nd
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("minutes");
            var x = Convert.ToInt32(Console.ReadLine());
           
            Console.WriteLine("Tai yra {0} valandos ir {1} minutes ! ", x/60, x% 60);
            Console.ReadKey();
            
        }
    }
}
