using Microsoft.AspNetCore.Mvc;
using SmallSchoolApp.Models;
namespace SmallSchoolApp.Controllers
{
    public class StudentController : Controller
    {

        #region Hardcoded list of students
        //private List<Student> studentsClassA = new List<Student>
        //{
        //    new Student("John", "Doe", "A", 3.5),
        //    new Student("Jane", "Smith", "A", 3.0),
        //    new Student("Alice", "Jones", "A", 2.5),
        //    new Student("Bob", "Brown", "A", 2.0),
        //    new Student("Charlie", "Davis", "A", 1.0)
        //};
        //private List<Student> studentsClassB = new List<Student>
        //{
        //    new Student("David", "White", "B", 3.5),
        //    new Student("Eve", "Black", "B", 3.0),
        //    new Student("Frank", "Green", "B", 2.5),
        //    new Student("Grace", "Orange", "B", 2.0),
        //    new Student("Hank", "Purple", "B", 1.0)
        //};
        #endregion

        //Hardcoded to students's Details
        private List<Student> students = new List<Student>{
                 new Student("John", "Doe", 1, 15, "A", 3.5, "1.jpeg"),
                 new Student("Jane", "Smith", 2, 16, "A", 3.0, "2.jpeg"),
                new Student("Alice", "Jones", 3, 17, "A", 2.5, "2.jpeg"),
                 new Student("Bob", "Brown", 4, 18, "A", 2.0, "2.jpeg"),
                new Student("Charlie", "Davis", 5, 19, "A", 1.0, "2.jpeg"),
               new Student("David", "White", 6, 20, "B", 3.5, "2.jpeg"),
                 new Student("Eve", "Black", 7, 21, "B", 3.0, "2.jpeg"),
                 new Student("Frank", "Green", 8, 22, "B", 2.5, "2.jpeg"),
                new Student("Grace", "Orange", 9, 23, "B", 2.0, "2.jpeg"),
                new Student("Hank", "Purple", 10, 24, "B", 1.0, "2.jpeg")
    };

        [Route("/AllStudent")]
        [Route("/")]
        public IActionResult AllStudent()
        {
            return View(students);
        }
        [Route("/AllStudent/{classRoom}")]
        // show all students in list view with link to details student Page 
        public IActionResult AllStudent(string? classRoom)
        {
            ViewBag.classRoom = classRoom;
            
            List<Student>? filteredStudents = students.Where(student => student.getClassRoom() == classRoom).ToList();
            if(filteredStudents.Count == 0)
            {
                return Content("This ClassRoom doesn't contain any Students");
            }
            return View(filteredStudents);
        }

        [Route("/StudentDetails/{id:int}")]
        public IActionResult StudentDetails(int id)
        {
            Student? student = students.FirstOrDefault(i => i.id == id);  
            return View(student);
        }
    }
}
