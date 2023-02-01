using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_Modul._1_Dars_Delegate_Event
{
    internal class ActionExample
    {
        public static void Run()
        {
            Action<string> PrintCosoleAction = message => Console.WriteLine(message);
            PrintCosoleAction("Action amalda ishlash tarzi");
        }
    }
}
