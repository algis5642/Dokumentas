using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_nd
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("laipsniai i farenheitus:");
            var laip = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("farenheitai :" +((laip*1.8)+32));
            Console.ReadKey();
        }
    }
}
