using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17_01
{
    class Program
    {
        static void Main(string[] args)
        {
            var vardas = "adda";
            var pavarde = "Pavardenis";
            var programa = new Program();
            programa.vardopaklausimas();
            programa.pasisveikinti1("algirdas");
            programa.atsisveikinti("vardas");
            programa.pasi("ponas", "tarakonas");
            programa.Suma(5, 6);
            programa.dalmuo(5, 6);
            Console.WriteLine(programa.Suma(1, 1));
            Console.WriteLine(programa.dalmuo(5, 6));
            programa.skaiciuotuvasMandras();
            programa.Ivedimas(ref vardas, ref pavarde);
            Console.WriteLine("naujas vardas " + vardas);
            Console.WriteLine("nauja pavarde" + pavarde);


            Console.ReadKey();

        }

        public void vardopaklausimas()
        {
            Console.WriteLine("koks jusu vardas");
            var vardas = Console.ReadLine();
        }

        public void pasisveikinti1(string vardas)
        {
            Console.WriteLine("labas");


        }

        public void atsisveikinti(string vardas)
        {
            Console.WriteLine("Viso gero!" + vardas);
        }

        public void pasi(string vardas, string pavarde)
        {
            Console.WriteLine(vardas);
            Console.WriteLine(pavarde);
        }

        public int Suma(int s1, int s2)
        {
            return s1 + s2;
        }

        public double dalmuo(int pirmas, int antras)
        {
            return (double)pirmas / antras;


        }

        public void skaiciuotuvasMandras()
        {
            Console.WriteLine("ivesti skaicius sumos metodui");
            var pirmas = Convert.ToInt32(Console.ReadLine());
            var antras = Convert.ToInt32(Console.ReadLine());

            var suma = Suma(pirmas, antras);

            Console.WriteLine(Suma(pirmas, antras));
        }

        public void Ivedimas(ref string vardas, ref string pavarde)
        {
            Console.WriteLine("dabartiniai duomenys");
            Console.WriteLine("vardas:" + vardas);
            Console.WriteLine("pavarde : " + pavarde);
            Console.WriteLine("naujas vardas: ");
            vardas = Console.ReadLine();
            Console.WriteLine("nauja pavarde :");
            pavarde = Console.ReadLine();
        }

    }




}




