namespace SmallSchoolApp.Models
{
    public class Student : Person
    {
        private string? classRoom { get; set; }
        private double? gpa { get; set; }
        private string? img { get; set; }

        // Constructors
        public Student()
        {

        }

        public Student(string firstName, string lastName, string classRoom, double gpa,string img)
        {
            this.FirstName = firstName;
            this.LastName = lastName;   
            this.classRoom = classRoom;
            this.gpa = gpa;
            this.img = img;
        }
        public Student(string firstName, string lastName, int id, int age, string classRoom, double gpa, string img)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.id = id;
            this.age = age;
            this.classRoom = classRoom;
            this.gpa = gpa;
            this.img = img;
        }

        // Methods
        public string getClassRoom()
        {
            return this.classRoom;
        }
        public double? getGpa()
        {
            return this.gpa;
        }

        public string? getImg()
        {
            return this.img;
        }
    }
}
