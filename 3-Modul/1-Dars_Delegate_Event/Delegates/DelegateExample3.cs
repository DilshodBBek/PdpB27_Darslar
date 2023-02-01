using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_Modul._1_Dars_Delegate_Event.Delegates
{
    internal class DelegateExample3
    {
        public static string message = "Hello I am Donald Tramp. Time: " + DateTime.Now;
        public delegate bool SmsServicePointer(int number);    
        static SmsServicePointer smsSenderPointer = SendSMS;
        public static void Run()
        {
            bool result = smsSenderPointer(901112233);
            Console.WriteLine("Email message:'{0}' was sent to McDonald_Tramp@gmail.com", message);
        }

        public static bool SendSMS(int phone)
        {
            Console.WriteLine("Sms message:'{0}' Phone number:'{1}'", message, phone);
            return true;
        }
    }
}
