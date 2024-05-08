namespace SmallSchoolApp.Models
{
    public class Class
    {
        string? ClassName { get; set; }
        private int? classSize { get; set; }
        private List<Student>? Students { get; set; }
        private Teacher? Teacher { get; set; }
        private List<string>? Subjects { get; set; }

        public string? GetClassName()
        {
            return ClassName;
        }
        public List<Student>? GetStudents()
        {
            return Students;
        }
        public Teacher? GetTeacher()
        {
            return Teacher;
        }
    }
}
