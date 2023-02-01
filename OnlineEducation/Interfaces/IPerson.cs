using OnlineEducation.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineEducation.Interfaces
{
    internal interface IPerson
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public string Phone { get; set; }
        public Account Account { get; set; }
    }
}
