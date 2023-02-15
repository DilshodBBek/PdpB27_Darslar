using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_Modul.Lesson_6_JSON_XML.JSON_Example
{
    public record Account
    {
        public int Id { get; set; }
        public string Email { get; set; }
        public bool Active { get; set; }
        public DateTime CreatedDate { get; set; }
        
        //public List<string> Roles { get; set; }
    }
}
