namespace StudentAdministrasjonsSystem
{
    public class Student
    {
        public string Navn { get; set; }
        public int Alder { get; set; }
        public List<Fag> StudieProgram { get; set; }
        public string StudentID { get; set; }

        public Student(string navn, int alder, List<Fag> studieProgram, string studentID)
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
            Console.WriteLine($"Student ID:     {StudentID}");
            Console.WriteLine("Studie Program:");
            foreach ( Fag fag in StudieProgram)
                Console.WriteLine($"    {fag.FagNavn}");
        }

        public void GjennomsnittKarakter()
        {
        }
        public int KarakterTilTall(int Karakter)
        {
            switch (Karakter)
            {
                case 'A':
                    return 5;
                case 'B':
                    return 4;
                case 'C':
                    return 3;
                case 'D':
                    return 2;
                case 'F':
                    return 1;
                default:
                    return 0;
            }
        }
    }
}
