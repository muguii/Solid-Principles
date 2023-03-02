namespace PrincipiosSOLID.SRP
{
    public class PersonDto
    {
        public string Name { get; private set; }
        public string Document { get; private set; }
        public DateTime BirthDate { get; private set; }

        public PersonDto(string name, string document, DateTime birthDate)
        {
            this.Name = name;
            this.Document = document;
            this.BirthDate = birthDate;
        }
    }
}