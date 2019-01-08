using System;
using System.Collections.Generic;
using System.Text;

namespace W05
{
    public delegate void Processor(Course course);
    class CourseList : List<Course>
    {
        public void ProcessCourses(Processor processor)
        {
            foreach (Course course in this)
            {
                processor(course);
            }
        }
    }
}
