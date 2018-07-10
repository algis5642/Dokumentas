using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13_nd
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Iveskite valandas o paskui minutes");
            var x = Convert.ToInt32(Console.ReadLine());
            var z = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Tai yra {0} minutes ! ", x * 60 + z);
            Console.ReadKey();
        }
    }
}
