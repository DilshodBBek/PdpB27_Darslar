namespace _3_Modul.Lesson7_Multithreading.Parallelism
{
    internal class Task_example
    {
        public void Run()
        {
            Console.WriteLine("Run start");
            ////AsyncTask();
            ////await MyTask();
            ////if (!res.IsCompleted)
            ////{
            ////    res.Start();
            ////}
            //Console.WriteLine(StringTask().Result);
            //Console.Read();
            Task<int> resSoliq = SenderSoliq("55455");
            Task<string> res = SenderIIB("5555");

            Console.WriteLine("Run stop");
            // Task.WaitAll(resSoliq, res);        

            Task.Run(() =>
            {
                Console.WriteLine("hello");
            });

            SoliqTest(resSoliq);
            Console.WriteLine("Main Thread");
            Console.ReadKey();
        }

         Task SoliqTest(Task<int> resSoliq)
        {
            //Console.WriteLine(resSoliq.Result);
            Task mytask = new Task(() =>
             {
                // Task.Delay(TimeSpan.FromSeconds(9));
                 Console.WriteLine("hi");
             });
            mytask.Start();
            Task task1 = new(action);
            task1.Start();
            //Thread.Sleep(TimeSpan.FromSeconds(3));
            Console.WriteLine("Salom");
            return mytask;
        }
        void Test()
        {
            Console.WriteLine("test");
        }
        Action action = async () =>
        {
            Console.WriteLine(Thread.CurrentThread.ManagedThreadId + " action start..");
            await Task.Delay(2000);
            Console.WriteLine(Thread.CurrentThread.ManagedThreadId+ " action");
        };
       async Task Chellenge()
        {
            Console.WriteLine("hi");
            //return Task.CompletedTask;
        }
        public async Task AsyncTask()
        {
            await Task.Delay(2000);
            Task.Run(() =>
            {
                Console.WriteLine("Current Thread:" + Thread.CurrentThread.Name + " Task.Run");
            });
            Console.WriteLine("Current Thread:" + Thread.CurrentThread.ManagedThreadId + " AsyncTask Delay stopped.");
        }
        async Task MyTask()
        {
            Console.WriteLine("MyTask start");

            Task result = new(() =>
            {
                Task.Delay(5000);
                Console.WriteLine("result task work");
            });
            result.Start();
            await Task.Delay(3000);
            Console.WriteLine("MyTask Delay stopped.");

            // return Task.CompletedTask;
        }
        async Task<string> StringTask()
        {
            Task<string> stringRes = new(() =>
            {
                Console.WriteLine("stringRes");
                return "test";
            });
            stringRes.Start();
            string result = await stringRes;
            Console.WriteLine("1234567");
            return result;
        }

        async Task<string> SenderIIB(string PassportID)
        {
            Task<string> yuborish = new(() =>
            {
                Task.Delay(4000).Wait();
                return $"Tom {PassportID}";
            });
            yuborish.Start();
            Console.WriteLine("yuborildi . . .");

            return await yuborish;
        }
        async Task<int> SenderSoliq(string PassportID)
        {
            Task<int> yuborish = new(() =>
             {
                 Task.Delay(4000).Wait();
                 return 550000;
             });
            yuborish.Start();
            Console.WriteLine("Yuborildi ...");

            return await yuborish;


        }
    }
}
