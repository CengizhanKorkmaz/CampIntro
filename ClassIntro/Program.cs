using System;

namespace ClassIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            Course course1=new Course();
            course1.CourseInstructor = "Cengizhan Korkmaz";
            course1.CourseName = "C#";
            course1.CourseWatchRate = 78;

            Course course2 = new Course();
            course2.CourseInstructor = "Cengizhan Korkmaz";
            course2.CourseName = "Java";
            course2.CourseWatchRate = 78;

            Course course3 = new Course();
            course3.CourseInstructor = "Cengizhan Korkmaz";
            course3.CourseName = "C++";
            course3.CourseWatchRate = 58;

            Course[] courses = new Course[] {course1,course2,course3};
            //Console.WriteLine(course1.CourseInstructor + " " + course1.CourseName + " " + course1.CourseWatchRate);
            foreach (Course course in courses)
            {
                Console.WriteLine(course.CourseName + " " + course.CourseInstructor);
            }
        }
        class Course
        {
            public string CourseName { get; set; }
            public string CourseInstructor{ get; set; }
            public int CourseWatchRate { get; set; }
        }
    }
}
