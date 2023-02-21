using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_Modul.Lesson7_Multithreading.Parallelism
{
    internal class Cancel_Task_Example
    {
        CancellationTokenSource _token = new CancellationTokenSource(5000);
        
       public  void Run()
        {
            LongRunningTask(100000, _token.Token).Wait();

            Console.Read();
        }
        public static async Task LongRunningTask(int count, CancellationToken token)
        {
            var stopwatch = new Stopwatch();
            stopwatch.Start();
            Console.WriteLine("\nLongRunningTask Started");
            for (int i = 1; i <= count; i++)
            {
                await Task.Delay(1000);
                Console.WriteLine("LongRunningTask Processing....");
                if (token.IsCancellationRequested)
                {
                    Console.WriteLine("Vaqt tugadi");
                }
            }
            stopwatch.Stop();
            Console.WriteLine($"LongRunningTask Took {stopwatch.ElapsedMilliseconds / 1000.0} Seconds for Processing");
        }
    }
}
