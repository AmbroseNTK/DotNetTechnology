using System;
using System.Collections.Generic;
using System.Text;

namespace W05
{
    public class Course
    {
        private double grade;
        private string id;
        private string courseName;
        private string lecturer;

        public Course() { }

        public Course(double grade, string id, string courseName, string lecturer)
        {
            this.grade = grade;
            this.id = id;
            this.courseName = courseName;
            this.lecturer = lecturer;
        }

        public double Grade { get => grade; set => grade = value; }
        public string Id { get => id; set => id = value; }
        public string CourseName { get => courseName; set => courseName = value; }
        public string Lecturer { get => lecturer; set => lecturer = value; }
    }
}
