using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_Modul.Regex_3_Lesson.StringComparisonLesson
{
    internal class StringComparisonExamples
    {
        public static void Run()
        {
            string[] lines = new string[]
{
    @"c:\public\textfile.txt",
    @"c:\public\textFile.TXT",
    @"c:\public\Text.txt",
    @"c:\public\testfile2.txt"
};

            Console.WriteLine("Non-sorted order:");
            foreach (string s in lines)
            {
                Console.WriteLine($"   {s}");
            }

            Console.WriteLine("\n\rSorted order:");

            // Specify Ordinal to demonstrate the different behavior.
            Array.Sort(lines, StringComparer.CurrentCulture);

            foreach (string s in lines)
            {
                Console.WriteLine($"   {s}");
            }
        }
    }
}
