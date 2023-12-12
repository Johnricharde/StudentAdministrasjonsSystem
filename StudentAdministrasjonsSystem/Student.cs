using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentAdministrasjonsSystem
{
    internal class Student
    {
        string Navn { get; set; }
        int Alder { get; set; }
        string StudieProgram { get; set; }
        string StudentID { get; set; }

        public Student(string navn, int alder, string studieProgram, string studentID)
        {
            Navn = navn;
            Alder = alder;
            StudieProgram = studieProgram;
            StudentID = studentID;
        }
        public void SkrivUtInfo()
        {
            Console.WriteLine($"Navn:           {Navn}");
            Console.WriteLine($"Alder:          {Alder}");
            Console.WriteLine($"Studie Program: {StudieProgram}");
            Console.WriteLine($"Student ID:     {StudentID}");
        }
    }
}
