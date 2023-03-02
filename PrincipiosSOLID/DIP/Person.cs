namespace PrincipiosSOLID.DIP
{
    public class Person
    {
        public int Id { get; private set; }
        public string Name { get; private set; }
        public string Document { get; private set; }
        public DateTime BirthDate { get; private set; }

        public Person(string name, string document, DateTime birthDate)
        {
            this.Name = name;
            this.Document = document;
            this.BirthDate = birthDate;
        }
    }
}