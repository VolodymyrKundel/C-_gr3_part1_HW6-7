namespace C__gr3_part1_HW6
{
    public class Student : Human
    {
        public int Age { get; set; }
        public string City { get; set; }

        public List<Course> ListOfCourses = new List<Course>();

        public Student(string firstName, string lastName, int age, string city)
        {
            FirstName = firstName;
            LastName = lastName;
            Age = age;
            City = city;
        }

        public Student(string firstName, string lastName, int age) : this(firstName, lastName, age, "NoCity") { }

        public Student(string firstName, string lastName) : this(firstName, lastName, -1) { }

        public Student(string firstName) : this(firstName, "NoLastName") { }

        public Student() : this("NoFirstName") { }

        public void Print()
        {
            Console.WriteLine("First Name is: " + FirstName);
            Console.WriteLine("Last Name is: " + LastName);
            Console.WriteLine("Age is: " + Age);
            Console.WriteLine("City is: " + City);
        }

        public void DescribeYourself()
        {
            Console.WriteLine("First Name is: " + FirstName);
            Console.WriteLine("Last Name is: " + LastName);
            Console.WriteLine("Age is: " + Age);
            Console.WriteLine("City is: " + City);
        }

        public void DisplayListOfCourses()
        {
            foreach (Course cs in ListOfCourses)
            {
                Console.WriteLine($"{cs.CourseName} {cs.TeacherName} {cs.CourseDuration} {cs.NumberOfStudents}");
            }
        }
    }
}
