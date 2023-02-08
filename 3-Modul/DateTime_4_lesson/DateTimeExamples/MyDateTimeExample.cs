using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_Modul.DateTime_4_lesson.DateTimeExamples
{
    internal class MyDateTimeExample
    {
        internal static void Run()
        {
            DateTime dateTime = new DateTime();
            //= DateTime.Parse(Console.ReadLine());  
            DateOnly dateOnly = new DateOnly(2023, 02,08);
            var sds=DateOnly.MaxValue;
            Console.WriteLine(sds);
            Console.WriteLine(dateOnly.ToString("yyyy/MM/dd"));

            TimeOnly timeOnly = new TimeOnly();
            
            TimeSpan timeSpan = new TimeSpan(0, 0, 5);

            Console.WriteLine(timeSpan + " vaqt o`tdi\a\a\a\a\a\a\a\a");
            
            dateTime.Add(timeSpan);
            Thread.Sleep(timeSpan);
        }
    }
}
