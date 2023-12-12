using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentAdministrasjonsSystem
{
    internal class Karakter
    {

        public Student Student { get; set; }
        public Fag Fag { get; set; }
        public char Karakterverdi { get; set; }

        public Karakter(char karakterverdi)
        {
            Karakterverdi = karakterverdi;
        }

        public void SkrivUtInfo()
        {
            Console.WriteLine($"Student:  {Student}");
            Console.WriteLine($"Fag       {Fag}");
            Console.WriteLine($"Karakter: {Karakterverdi}");
        }
    }
}
