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
        public List<Fag> Fag { get; set; }
        public List<char> Karakterverdier { get; set; }

        public Karakter(Student student, List<Fag> fag, List<char> karakterverdier)
        {
            Student = student;
            Fag = fag;
            Karakterverdier = karakterverdier;
        }

        public void SkrivUtInfo()
        {
            Console.WriteLine($"Student:  {Student.Navn}");
            Console.WriteLine("Fag:");

            for (int i = 0; i < Fag.Count; i++)
                Console.WriteLine($"  {Fag[i].FagNavn} \t {Karakterverdier[i]}");
        }
    }
}
