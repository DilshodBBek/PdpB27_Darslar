using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_Modul.Lesson7_System_Net_Http.Multithreading
{
    internal class Multithread_Examples
    {
        public static void Start()
        {
            Thread currentThread = Thread.CurrentThread;

            Console.WriteLine($"Имя потока: {currentThread.Name}");
            currentThread.Name = "Метод Main";
            Console.WriteLine($"Имя потока: {currentThread.Name}");

            Console.WriteLine($"Запущен ли поток: {currentThread.IsAlive}");
            Console.WriteLine($"Id потока: {currentThread.ManagedThreadId}");
            Console.WriteLine($"Приоритет потока: {currentThread.Priority}");
            Console.WriteLine($"Статус потока: {currentThread.ThreadState}");
        }
    }
}
