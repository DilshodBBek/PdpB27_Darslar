using OnlineEducation.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineEducation.Interfaces
{
    internal interface ICourseDetails
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public int Duration { get; set; }

        public void GetDetails();
    }
}
