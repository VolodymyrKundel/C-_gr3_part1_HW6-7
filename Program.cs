using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;

namespace C__gr3_part1_HW6
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Student studentV = new Student("V");
            Course courseCSharp = new Course() { CourseName = "C Sharp" , TeacherName = "Kris" , NumberOfStudents = 12 };
            Teacher teacherKris = new Teacher() { FirstName = "Kris", LastName = "G", Brain = true };

            studentV.Print();
            Console.WriteLine();
            courseCSharp.Print();

            courseCSharp.NumberOfStudents++;

            Console.WriteLine();
            courseCSharp.Print();

            Console.WriteLine();
            studentV.DescribeYourself();

            Console.WriteLine();
            teacherKris.DescribeYourself();

            Console.WriteLine();
            teacherKris.ListOfStudents.Add(studentV);
            teacherKris.DisplayListOfStudents();
            Console.WriteLine($"Number of students: {teacherKris.ListOfStudents.Count}");

            Console.WriteLine();
            teacherKris.ListOfStudents.Remove(studentV);
            teacherKris.DisplayListOfStudents();
            Console.WriteLine($"Number of students: {teacherKris.ListOfStudents.Count}");

            // for HW8

            Student studentB = new Student() { FirstName = "Boris", LastName = "Johnson"};
            Student studentJ = new Student() { FirstName = "Joe", LastName = "Biden" };

            Teacher teacherJames = new Teacher() { FirstName = "James", Brain = false };
            Teacher teacherScott = new Teacher() { FirstName = "Scott", Brain = true };

            Course coursePhysics = new Course() { CourseName = "Physics" , TeacherName = teacherJames.FirstName};
            Course courseAlgebra = new Course() { CourseName = "Algebra", TeacherName = teacherScott.FirstName };
            Course courseGeometry = new Course() { CourseName = "Geometry", TeacherName = teacherScott.FirstName };

            List<Student> Students = new List<Student>() { studentV, studentB, studentJ };
            List<Course> Courses = new List<Course>() { courseCSharp, coursePhysics, courseAlgebra, courseGeometry };
            List<Teacher> Teachers = new List<Teacher>() { teacherKris, teacherJames, teacherScott };

            studentV.ListOfCourses.Add(courseCSharp);

            studentB.ListOfCourses.Add(coursePhysics);
            studentB.ListOfCourses.Add(courseCSharp);

            studentJ.ListOfCourses.Add(courseAlgebra);
            studentJ.ListOfCourses.Add(courseGeometry);

            teacherKris.ListOfStudents.Add(studentV);
            teacherKris.ListOfCourses.Add(courseCSharp);

            teacherJames.ListOfCourses.Add(coursePhysics);

            teacherScott.ListOfCourses.Add(courseAlgebra);
            teacherScott.ListOfCourses.Add(courseGeometry);

            Console.WriteLine("****************************");
            Console.WriteLine("\nDisplaying all Students:\n");


            //Students.ForEach(st =>
            //{
            //    Console.WriteLine(st.ToString());
            //    st.ListOfCourses.ForEach(cor => cor.ToString());
            //});

            foreach (Student s in Students)
            {
                s.Print();
            }

            Console.WriteLine("\nDisplaying all Teachers:\n");
            foreach (Teacher t in Teachers)
            {
                t.Print();
            }


            Console.WriteLine("\nDisplaying all Courses:\n");
            foreach (var c in Courses)
            {
                Console.WriteLine($"Course name is: {c.CourseName}");

                var thr = Teachers.FirstOrDefault(x => x.FirstName == c.TeacherName);
                Console.WriteLine($"Teacher's Name: {thr.FirstName} {thr.LastName}");

                foreach (var st in Students)
                {
                    foreach (var cs in st.ListOfCourses)
                        if (cs.CourseName == c.CourseName)
                            c.ListOfStudents.Add(st);
                }

                c.DisplayListOfStudents();
            }
        }
    }
}