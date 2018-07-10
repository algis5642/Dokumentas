using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_04
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sveiki, iveskite tris skaicius:");
            var pirmas = Convert.ToInt32(Console.ReadLine());
            var antras = Convert.ToInt32(Console.ReadLine());
            var trecias = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("skaiciu suma: {0}+{1}+{2}={3} ", pirmas, antras, trecias, pirmas+antras+trecias);
            Console.WriteLine("skaiciu skirtumas: {0}-{1}-{2}={3} ", pirmas, antras, trecias, pirmas - antras - trecias);
            Console.WriteLine("skaiciu sandauga: {0}*{1}*{2}={3} ", pirmas, antras, trecias, pirmas * antras * trecias);
            Console.WriteLine("skaiciu dalyba: {0}/{1}/{2}={3} ", pirmas, antras, trecias, pirmas / antras / trecias);
            Console.ReadKey();
        }
    }
}
