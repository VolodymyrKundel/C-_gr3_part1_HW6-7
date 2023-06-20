namespace C__gr3_part1_HW6
{
    public class Teacher: Human
    {
        public bool Brain { get; set; }

        public List<Student> ListOfStudents = new List<Student>();
        public List<Course> ListOfCourses = new List<Course>();

        public void DescribeYourself()
        {
            Console.WriteLine("First Name is: " + FirstName);
            Console.WriteLine("Last Name is: " + LastName);
            Console.WriteLine("Brain is: " + Brain);
        }

        public void DisplayListOfStudents()
        {
            foreach (Student st in ListOfStudents)
            {
                Console.WriteLine($"{st.FirstName} {st.LastName} {st.Age} {st.City}");
            }
        }

        public void Print()
        {
            Console.WriteLine("First Name is: " + FirstName);
            Console.WriteLine("Last Name is: " + LastName);
            Console.WriteLine("Brain is: " + Brain);

            DisplayListOfCourses();
        }

        public void DisplayListOfCourses()
        {
            Console.WriteLine("\tThe list of courses for this teacher:");
            foreach (Course cs in ListOfCourses)
            {
                Console.WriteLine($"\t\t{cs.CourseName}");
            }
        }
    }
}
