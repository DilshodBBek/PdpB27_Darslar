using System.Diagnostics;

namespace _3_Modul.Lesson7_Multithreading.Parallelism
{
    internal class Cancel_Task_Example
    {
        CancellationTokenSource _token = new CancellationTokenSource(4000);

        public void Run()
        {
            Stopwatch stopWatch = new Stopwatch();
            stopWatch.Start();
            //Calling Three methods Parallely
            Task a = ParrallelTask();
            //a.Start();  
            //Task.Run(() =>
            //{
            //    Parallel.Invoke(Method2, Method1, Method3);
            //    Console.WriteLine("Id Run() "+Thread.CurrentThread.ManagedThreadId);

            //});
            stopWatch.Stop();
            Console.WriteLine($"Parallel Execution Took {stopWatch.ElapsedMilliseconds} Milliseconds");
            Console.ReadKey();
            try
            {
                //ThreadStart
                // ParameterizedThreadStart
                Thread thread = new(ThreadMethod);
                thread.Start();

                TaskMethod();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            //ParameterizedThreadStart

            // _token.Cancel(false);
            //Thread.Sleep(3000);
            //Console.WriteLine(_token.TryReset());
            //LongRunningTask(100000, _token.Token);
            //Console.WriteLine("Read");
            //Console.Read();
        }
      async Task ParrallelTask()
        {
            Parallel.Invoke(Method2, Method1, Method3);
            Console.WriteLine("Id Run() " + Thread.CurrentThread.ManagedThreadId);
           // return Task.CompletedTask;  
        }
        static void Method1()
        {
            Thread.Sleep(200);
            Console.WriteLine($"Method 1 Completed by Thread={Thread.CurrentThread.Name + Thread.CurrentThread.ManagedThreadId}");
        }
        static void Method2()
        {
            Thread.Sleep(200);
            Console.WriteLine($"Method 2 Completed by Thread={Thread.CurrentThread.Name + Thread.CurrentThread.ManagedThreadId}");
        }
        static void Method3()
        {
            Thread.Sleep(200);
            Console.WriteLine($"Method 3 Completed by Thread={Thread.CurrentThread.Name + Thread.CurrentThread.ManagedThreadId}");
        }

        void ThreadMethod(object? obj)
        {
            //throw new Exception("ThreadException");

            Thread a = new(() => { Console.WriteLine("sdfsd"); });
            Thread b = new(() => { Console.WriteLine("sdfsd"); });
            Thread t = new(() => { Console.WriteLine("sdfsd"); });
            Thread r = new(() => { Console.WriteLine("sdfsd"); });
            // a.Start();
        }
        Task TaskMethod()
        {
            //throw new Exception("TaskException");
            Task.Run(() => { Console.WriteLine("sdfsd"); });
            Task.Run(() => { Console.WriteLine("sdfsd"); });
            Task.Run(() => { Console.WriteLine("sdfsd"); });
            return Task.CompletedTask;
        }
        public static async Task LongRunningTask(int count, CancellationToken token)
        {
            try
            {
                var stopwatch = new Stopwatch();
                stopwatch.Start();
                int a = 9;
                Action<object?, CancellationToken> action = HandleToken;
                token.Register(action, a);
                Console.WriteLine("LongRunningTask Started");
                for (int i = 1; i <= count; i++)
                {
                    token.ThrowIfCancellationRequested();
                    await Task.Delay(1000);

                    Console.WriteLine("LongRunningTask Processing....");
                    if (token.IsCancellationRequested)
                    {
                        Console.WriteLine(token.CanBeCanceled);
                        token.Register(action, a);

                        Console.WriteLine("Vaqt tugadi");
                    }
                }
                void HandleToken(object? obj, CancellationToken token)
                {
                    Console.WriteLine("HandleToken");
                }
                stopwatch.Stop();
                Console.WriteLine($"LongRunningTask Took {stopwatch.ElapsedMilliseconds / 1000.0} Seconds for Processing");

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
