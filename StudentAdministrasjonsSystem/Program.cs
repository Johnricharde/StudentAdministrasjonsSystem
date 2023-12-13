using System.Collections.Generic;

namespace StudentAdministrasjonsSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {


            // Subjects
            var AlleFag = new List<Fag>
            {
                new Fag("101", "Matte", 30),
                new Fag("102", "Historie", 40),
                new Fag("103", "Biologi", 50)
            };

            // Students
            var student1 = new Student("Bob", 22, AlleFag, "A01");
            var student2 = new Student("Lea", 21, AlleFag, "A02");

            // Grades
            var karakter1 = new Karakter(student1, AlleFag, new List<char> { 'A', 'B', 'A' });
            var karakter2 = new Karakter(student2, AlleFag, new List<char> { 'F', 'C', 'D' });


            student1.SkrivUtInfo();
            Console.WriteLine();
            student2.SkrivUtInfo();

            //foreach (var fag in AlleFag)
            //{
            //    fag.SkrivUtInfo();
            //    Console.WriteLine();
            //}

            //karakter1.SkrivUtInfo();
            //Console.WriteLine();
            //karakter2.SkrivUtInfo();

        }
    }
}
