using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentAdministrasjonsSystem
{
    public class Fag
    {
        public string FagKode { get; set; }
        public string FagNavn { get; set; }
        public int AntallStudiepoeng { get; set; }

        public Fag(string fagKode, string fagNavn, int antallStudiepoeng)
        {
            FagKode = fagKode;
            FagNavn = fagNavn;
            AntallStudiepoeng = antallStudiepoeng;
        }
        public void SkrivUtInfo()
        {
            Console.WriteLine($"Fag Kode:    {FagKode}");
            Console.WriteLine($"Fag Navn:    {FagNavn}");
            Console.WriteLine($"Studiepoeng: {AntallStudiepoeng}");
        }
    }
}
