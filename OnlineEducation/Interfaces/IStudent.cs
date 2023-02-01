using OnlineEducation.Models;
using OnlineEducation.States;

namespace OnlineEducation.Interfaces
{
    internal interface IStudent : IPerson
    {
        public List<string> StudentFeedbacks { get; set; }
        public StudentStatus Status { get; set; }

        public void BuyCourse(CourseDetails course);

        public void FinishCourse(CourseDetails course);


    }
}
