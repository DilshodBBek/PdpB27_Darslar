using OnlineEducation.Interfaces;
using OnlineEducation.States;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineEducation.Models
{
    internal class Teacher : ITeacher
    {
        public TeacherStatus Status { get; set; }
        public CourseDetails TeachingCourse { get; set; }
        public int Id { get; set; }
        public string Name { get; set; }
        public string Phone { get; set; }
        public Account Account { get; set; }

        public void GetSalary()
        {
            if (Account.AccountStatus==AccountStatus.Active)
            {
                Console.WriteLine("{0} Get salary {1} ", Name, 99999);
            }
        }

        public void Teach()
        {
            Console.WriteLine(TeachingCourse.Name+" Lesson started..");
        }
    }
}
