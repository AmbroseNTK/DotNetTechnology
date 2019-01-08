using System;
using System.Collections.Generic;
using System.Text;

namespace W05
{
    class Student
    {
        private double totalGrade;
        private int totalCourse;
        private double min = 10d;

        public Student() { }

        public Student(double totalGrade, int totalCourse, double min)
        {
            this.TotalGrade = totalGrade;
            this.TotalCourse = totalCourse;
            this.min = min;
        }


        public double Min { get => min; set => min = value; }
        public int TotalCourse { get => totalCourse; set => totalCourse = value; }
        public double TotalGrade { get => totalGrade; set => totalGrade = value; }

        public void AddCourseToTotal(Course course)
        {
            TotalCourse++;
        }
        public void AddGradeToTotal(Course course)
        {
            TotalGrade += course.Grade;
        }
        public void MinGrade(Course course)
        {
            if (min > course.Grade)
                min = course.Grade;
        }
        public double AverageGrade()
        {
            return TotalGrade / TotalCourse;
        }
    }
}
