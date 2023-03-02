namespace PrincipiosSOLID.LSP
{
    public class SimpleAverageGradeCalculator : IAverageGradeCalculator
    {
        public string Subject { get; set; }
        public int Year { get; set; }
        public int Semester { get; set; }

        public SimpleAverageGradeCalculator(string subject, int year, int semester)
        {
            Subject = subject;
            Year = year;
            Semester = semester;
        }

        public double Calculate(int[] grades)
        {
            return Math.Floor(grades.Average());
        }
    }
}
