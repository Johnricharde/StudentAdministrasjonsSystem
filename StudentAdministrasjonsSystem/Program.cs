using System.Collections.Generic;

namespace StudentAdministrasjonsSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var student1 = new Student("Bob", 22, "Studie Program A", "A01");

            var student2 = new Student("Lea", 21, "Studie Program B", "A02");

            //var fag1 = new Fag("101", "Historie", 60);
            //var fag2 = new Fag("102", "Matte", 30);

            var karakter1 = new Karakter('A');
            var karakter2 = new Karakter('F');

            var AlleFag = new List<Fag>
            {
                new Fag("101", "Matte", 30),
                new Fag("102", "Historie", 40),
                new Fag("103", "Biologi", 50)
            };

            //student1.SkrivUtInfo();
            //Console.WriteLine();
            //student2.SkrivUtInfo();

            foreach (var fag in AlleFag)
            {
                fag.SkrivUtInfo();
                Console.WriteLine();
            }

            //karakter1.SkrivUtInfo();
            //Console.WriteLine();
            //karakter2.SkrivUtInfo();

        }
    }
}
