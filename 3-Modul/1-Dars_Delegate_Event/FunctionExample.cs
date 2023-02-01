using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_Modul._1_Dars_Delegate_Event
{
    internal class FunctionExample
    {
        public static string message = "Hello I am Donald Tramp. Time: " + DateTime.Now;
        public static void Run()
        {
            Func<int, bool> smsSenderPointer = phone =>
            {
                Console.WriteLine("Sms message:'{0}' Phone number:'{1}'", message, phone);
                return true;
            };
            bool result = smsSenderPointer(901112233);
            Console.WriteLine("Email message:'{0}' was sent to McDonald_Tramp@gmail.com", message);
        }
    }
}
