using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_Modul._1_Dars_Delegate_Event.Events
{
    internal class SendSmsEventArgs:EventArgs
    {
        public int Id { get; set; }
        public string Message { get; set; }
        public DateTime SendDate { get; set; }

        public override string ToString()
        {
            return $"Id: {Id}, Message:{Message}, SendDate:{SendDate}";
        }

    }
}
