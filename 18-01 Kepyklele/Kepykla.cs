using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18_01_Kepyklele
{
    class Kepykla
    {
        public String Pavadinimas { get;private set; }
        public String Adresas { get;private set; }
        public List<Duona> Duonos { get;private set; }

        public Kepykla()
        {
            Duonos = new List<Duona>();
        }

        public Kepykla(string pavadinimas, string adresas, List<Duona> duonos)
        {
            Pavadinimas = pavadinimas;
            Adresas = adresas;
            Duonos = duonos;
        }
        public void isvedimas()
        {
            Console.WriteLine("Kepykla : " + Pavadinimas);
            Console.WriteLine("Adresu: " +Adresas);
            foreach (var duona in Duonos)
            {
                Console.WriteLine("duonos pav: " +duona);
            }
        }

    }
}
