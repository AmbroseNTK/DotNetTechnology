using System;

namespace W05
{
    class Program
    {
        static void Main(string[] args)
        {
            CourseList courseList = new CourseList();
            Random random = new Random();
            for (int i = 0; i < random.Next(10, 20); i++)
            {
                courseList.Add(new Course(random.NextDouble() * 10, "ID " + random.Next(1, 100), "Course" + random.Next(1, 100), "Lecturer " + random.Next(1, 100)));

            }

            Student student = new Student();

            courseList.ProcessCourses(student.AddGradeToTotal);
            courseList.ProcessCourses(student.AddCourseToTotal);
            courseList.ProcessCourses(student.MinGrade);

            Console.WriteLine("Total grade = " + student.TotalGrade);
            Console.WriteLine("Total course = " + student.TotalCourse);
            Console.WriteLine("Min grade = " + student.Min);
            Console.WriteLine("GPA = " + student.AverageGrade());
            Console.WriteLine("Course list: ");
            courseList.ProcessCourses((Course course) =>
            {
                Console.WriteLine(course.CourseName);
            });
            Console.Read();
        }
    }
}
