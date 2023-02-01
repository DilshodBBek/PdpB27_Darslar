using OnlineEducation.InitStaticData;
using OnlineEducation.Models;

namespace OnlineEducation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Kurslar ro`yxati:");
            List<CourseDetails> courses = new();
            InitData.InitCourses(ref courses);

            foreach (var item in courses)
            {
                item.GetDetails();
            }
            Student student = new Student()
            {
                Account = Account.AddAccount("123"),
                Name = "John",
                Phone = "123",
                Status = States.StudentStatus.Beginner
            };

        }
    }
}