using OnlineEducation.Models;

namespace OnlineEducation.InitStaticData
{
    internal static class InitData
    {
        public static void InitCourses(ref List<CourseDetails> courses)
        {
            courses.Add(new CourseDetails() { Duration = 90, Id = 123, Name = "C#", Price = 345 });
            courses.Add(new CourseDetails() { Duration = 90, Id = 122, Name = "Java", Price = 333 });
            courses.Add(new CourseDetails() { Duration = 70, Id = 113, Name = "C++", Price = 355 });
        }
    }
}
