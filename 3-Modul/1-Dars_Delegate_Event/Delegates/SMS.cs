using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static _3_Modul._1_Dars_Delegate_Event.Delegates.DelegateExamples;

namespace _3_Modul._1_Dars_Delegate_Event.Delegates
{
    
    internal class SMS
    {
       public SendSMS sms = SendSmsMessage;
        public static bool SendSmsMessage(string text, int number )
        {
            Console.WriteLine($"sms text {text} sent to phone number:{number} ");
            return true;
        }
    }
}
