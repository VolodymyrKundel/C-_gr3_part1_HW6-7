namespace C__gr3_part1_HW6
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Student student = new Student("V");
            Course course = new Course() { TeacherName = "Kris" };
            Teacher teacher = new Teacher() { FirstName = "Kris", LastName = "G", Brain = true };

            student.Print();
            Console.WriteLine();
            course.Print();

            course.NumberOfStudents++;

            Console.WriteLine();
            course.Print();

            Console.WriteLine();
            student.DescribeYourself();

            Console.WriteLine();
            teacher.DescribeYourself();

            Console.WriteLine();
            teacher.ListOfStudents.Add(student);
            teacher.DisplayListOfStudents();
            Console.WriteLine($"Number of students: {teacher.ListOfStudents.Count}");

            Console.WriteLine();
            teacher.ListOfStudents.Remove(student);
            teacher.DisplayListOfStudents();
            Console.WriteLine($"Number of students: {teacher.ListOfStudents.Count}");
        }
    }
}