namespace upp1.Models
{
    public class PersonModel
    {
        public string? First_Name { get; set; }
        public string? Last_Name { get; set;  }
        public int? Age { get; set; }

        public PersonModel() { }

        public PersonModel(string firstName, string lastName, int age)
        {
            this.First_Name = firstName;
            this.Last_Name = lastName;
            this.Age = age; 
        }
    }
}
