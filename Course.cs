
namespace C__gr3_part1_HW6
{
    public class Course
    {
        public string CourseName { get; set; }
        public string TeacherName { get; set; }
        public int CourseDuration { get; set; }
        public int NumberOfStudents { get; set; }

        public List<Student> ListOfStudents = new List<Student>();

        public Course(string courseName, string teacherName, int courseDuration, int numberOfStudents)
        {
            CourseName = courseName;
            TeacherName = teacherName;
            CourseDuration = courseDuration;
            NumberOfStudents = numberOfStudents;
        }
        public Course(string courseName, string teacherName, int courseDuration) : this(courseName, teacherName, -1, -1) { }

        public Course(string courseName, string teacherName) : this(courseName, teacherName, -1) { }

        public Course(string courseName) : this(courseName, "NoTeacher'sName") { }

        public Course() : this("NoCourseName") { }

        public void Print()
        {
            Console.WriteLine("Course Name is: " + CourseName);
            Console.WriteLine("Teacher's Name is: " + TeacherName);
            Console.WriteLine("Course Duration is: " + CourseDuration);
            Console.WriteLine("Number of Students is: " + NumberOfStudents);
        }

        public void DisplayListOfStudents()
        {
            Console.WriteLine("\tThe list of Students for this course:");
            foreach (Student st in ListOfStudents)
            {
                Console.WriteLine($"\t\t{st.FirstName} {st.LastName} {st.Age} {st.City}");
            }
        }
    }
}
