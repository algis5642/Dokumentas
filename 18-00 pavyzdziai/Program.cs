using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18_00_pavyzdziai
{
    class Studentas
    {
        public String Vardas;
        public string Pavarde;
        public int Amzius;
        public string Universitetas;
        public string StudijuPrograma;
        public string Grupe;
        public int Kursas;

        public Studentas()
        {

        }

        public Studentas(string vardas, string pavarde, int amzius, string universitetas, string studijuPrograma, string grupe, int kursas)
        {
            Vardas = vardas;
            Pavarde = pavarde;
            Amzius = amzius;
            Universitetas = universitetas;
            StudijuPrograma = studijuPrograma;
            Grupe = grupe;
            Kursas = kursas;




        }

        public void Isvedimas()
        {
            Console.WriteLine("___________________________________________________________");
            Console.WriteLine(" Studento vardas {0} pavarde {1} amzius {2} Studijuoja universitete {3} studiju programa {4} {5} grupeje ir {6} kurse", Vardas, Pavarde, Amzius, Universitetas, StudijuPrograma, Grupe, Kursas);
            Console.WriteLine("___________________________________________________________");

            Console.WriteLine();
        }


    }

    class Program
    {
        

        static void Main(string[] args)
        {
            Studentas Petras1 = new Studentas();
            Studentas Petras2 = new Studentas();

            Petras1.Vardas = "Petras";
            Petras1.Pavarde = "Petraitis";
            Petras1.Amzius = 25;
            Petras1.Universitetas = "KTU";
            Petras1.StudijuPrograma = "Programus sistemos";
            Petras1.Grupe = "PS-4/2";
            Petras1.Kursas = 4;

            /*Console.WriteLine(Petras1.Vardas);
            Console.WriteLine(Petras1.Pavarde);
            Console.WriteLine(Petras1.Amzius);
            Console.WriteLine(Petras1.Universitetas);
            Console.WriteLine(Petras1.StudijuPrograma);
            Console.WriteLine(Petras1.Grupe);
            Console.WriteLine(Petras1.Kursas);*/

            Petras2.Vardas = "Petras";
            Petras2.Pavarde = "Petrauskas";
            Petras2.Amzius = 22;
            Petras2.Universitetas = "VDU";
            Petras2.StudijuPrograma = "Sistemos";
            Petras2.Grupe = "PS-0";
            Petras2.Kursas = 2;

            /*Console.WriteLine(Petras2.Vardas);
            Console.WriteLine(Petras2.Pavarde);
            Console.WriteLine(Petras2.Amzius);
            Console.WriteLine(Petras2.Universitetas);
            Console.WriteLine(Petras2.StudijuPrograma);
            Console.WriteLine(Petras2.Grupe);
            Console.WriteLine(Petras2.Kursas);*/

            Petras1.Isvedimas();
            Petras2.Isvedimas();

            var studentas = new Studentas("Jonas", "Jonaitis", 33, "Vdu", "Teologija", "Kazn", 1);
            studentas.Isvedimas();

            var grupe = new List<Studentas>();
            grupe.Add(new Studentas("Antanas", "Antanaitis", 88, "lez", "Klassd", "89", 5));
            grupe.Add(new Studentas("Anta2", "Antdadaadnaitis", 188, "l55ez", "Kdadlassd", "82", 25));
            grupe.Add(new Studentas("Antan3s", "Ant3anaitis", 838, "le3z", "K3lassd", "839", 53));
            grupe.Add(new Studentas("Antan4as", "Antan4aitis", 488, "4lez", "4Klassd", "894", 54));
            grupe.Add(new Studentas("Antan5as", "Antan5aitis", 885, "5lez", "Kla5ssd", "589", 55));
            grupe.Add(new Studentas("Ant6anas", "Ant6anaitis", 886, "6lez", "6Klassd", "869", 65));

            foreach (var stud in grupe)
            {
                stud.Isvedimas();
            }

            var programa = new Program();
            var vyriausias = programa.VyriausiasStudentas(grupe);
            Console.WriteLine("vyriausias studentas");
            vyriausias.Isvedimas();

            Console.WriteLine("vyriausias studentas");
            programa.VyriausiasStudentas(grupe).Isvedimas();

            Console.WriteLine("Pirmas Pirmakursis");
            programa.Fuksas(grupe).Isvedimas();

            var gyvunas = new Gyvunas("ruda", "ilgas", 4, 10);
            gyvunas.isvedimas();
            gyvunas.Gimtadienis();
            gyvunas.isvedimas();






            { }
            //Console.WriteLine("Hello World!");
            Console.ReadKey();
        }

        public Studentas VyriausiasStudentas(List<Studentas> grupe)
        {
            var vyriausias = grupe.First();
            foreach (var studentas in grupe)
            {
                if (studentas.Amzius > vyriausias.Amzius)
                {
                    vyriausias = studentas;
                }
            }
            return vyriausias;
        }

        public Studentas Fuksas(List<Studentas> grupe)
        {
            var fuksas = grupe.First();
            foreach (var studentas in grupe)
            {
                if (studentas.Kursas< fuksas.Kursas)
                {
                    fuksas = studentas;
                }
            }return fuksas;
        }

    }
}
