using PdpB27_Darslar.Collections;

namespace PdpB27_Darslar.Lesson9_Tuple_Nullable
{
    internal class TupleExamples
    {
        public static void TupleMain()
        {
            (double, int) t1 = (4.5, 3);
            Console.WriteLine($"Tuple with elements {t1.Item1} and {t1.Item2}.");
            // Output:
            // Tuple with elements 4.5 and 3.

            (double Sum, int Count) t2 = (4.5, 3);
            Console.WriteLine($"Sum of {t2.Count} elements is {t2.Sum}.");
            // Output:
            // Sum of 3 elements is 4.5.

            var t =(1, 2, 3, 4, 5, 6, (byte)7, 8, 9, 10,
                    11, 12, 13, 14, 15, new ListNode(), 17, 18,
                    19, 20, 21, 22, 23, 24, 25, "I am 26");

            Console.WriteLine(t.Item26);  // output: 26
            Console.WriteLine(t);

            var d = (Sum: 4.5, Count: 3);
            Console.WriteLine($"Sum of {d.Count} elements is {d.Sum}.");

            (double Sum, int Count) dt = (4.5, 3);
            Console.WriteLine($"Sum of {dt.Count} elements is {dt.Sum}.");

            var triangle = (alfa: 60, betta: 60, gamma: 60, A: 5, B: 5, C: 5);

            Console.WriteLine("alfa: "+triangle.alfa+" betta: "+triangle.betta);

        }
    }
}
