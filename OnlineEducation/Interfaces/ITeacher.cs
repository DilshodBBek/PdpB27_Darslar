using OnlineEducation.Models;
using OnlineEducation.States;

namespace OnlineEducation.Interfaces
{
    internal interface ITeacher : IPerson
    {
        public TeacherStatus Status { get; set; }
        public CourseDetails TeachingCourse { get; set; }
        void GetSalary();
        void Teach();
    }
}
