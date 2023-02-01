using OnlineEducation.Interfaces;

namespace OnlineEducation.Models
{
    internal class CourseDetails : ICourseDetails
    {
        public int Id { get; set; }
        public double Price { get; set; }
        public int Duration { get; set; }
        public string Name { get; set; }

        public void GetDetails()
        {
            Console.WriteLine($"{this.Name} Duration: {this.Duration} Price:{this.Price}");
        }
    }
}
