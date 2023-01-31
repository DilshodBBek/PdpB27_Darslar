using OnlineEducation.Interfaces;
using OnlineEducation.States;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineEducation.Models
{
    internal class Student : IStudent
    {
        public List<CourseDetails> Courses = new();
        public List<string> StudentFeedbacks { get; set; }
        public StudentStatus Status { get; set; }
        public int Id { get; set; }
        public string Name { get; set; }
        public string Phone { get; set; }
        public Account Account { get; set; }

        public void BuyCourse(CourseDetails course)
        {
            {
                if (!Courses.Contains(course))
                {
                    Courses.Add(course);
                    Console.WriteLine($"{Name} bought {course.Name}");
                }
                else { Console.WriteLine($"{Name} already bought {course.Name}"); ; }

            }
        }

        public void FinishCourse(CourseDetails course)
        {
            if (Courses.Contains(course))
            {
                Courses.Remove(course);
            }
        }
    }
}
