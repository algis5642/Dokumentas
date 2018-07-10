using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_07
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("prasome ivesti temperatura celcijaus skaleje");
            var temperatura = Convert.ToInt32( Console.ReadLine());
            Console.WriteLine("temperatura Farenheitu {0} temperatura kelvino skalej {1}", temperatura *1.8+32, temperatura-273);
            Console.ReadKey();
        }
    }
}
