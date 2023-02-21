using _3_Modul.Lesson7_Multithreading.Multithreading;
using _3_Modul.Lesson7_Multithreading.Parallelism;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_Modul.Lesson7_Multithreading
{
    internal class Startup
    {
        public static void Run()
        {
            //Multithread_Examples.Start();   
            //TPL_Examples.Run();
           //new Task_example().Run();
           new Cancel_Task_Example().Run();    
        }
    }
}
