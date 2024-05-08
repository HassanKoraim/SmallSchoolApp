namespace SmallSchoolApp.Models
{
    public class Person
    {
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public int? id { get; set; }
        public int? age { get; set; }

        // Constructor

        #region Constructors
        public Person(string firstName, string lastName, int id, int age)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.id = id;
            this.age = age;
        }
        public Person(string firstName, string lastName, int id)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.id = id;
        }
        public Person(string firstName, string lastName)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
        }
        public Person() { }
        #endregion
        // Methods

        public string getFullName()
        {
            return this.FirstName + " " + this.LastName;
        }
        public int? getAge()
        {
            return this.age;
        }   

        public int? getId()
        {
            return this.id;
        }

    }
}
