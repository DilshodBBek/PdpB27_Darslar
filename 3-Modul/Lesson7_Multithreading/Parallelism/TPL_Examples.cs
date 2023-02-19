namespace _3_Modul.Lesson7_Multithreading.Parallelism
{
    internal static class TPL_Examples
    {
        public static void Run()
        {
            Console.WriteLine("Run Method Started......");
            //PrintAsync();
            //// SomeMethod();
            //Console.WriteLine("Run Method End");
            //Console.ReadKey();
            //PrintAsync1();                   // This is an async void method and cannot be awaited
            //await PrintAsync2();
            // Call the method that calls the async methods
            //CallAsyncMethods();//#region Difference between Task and void
        }
        #region Difference between Task and void
        static async void AsyncVoidMethod()
        {
            throw new Exception("This is void Exception.");
        }

        static async Task AsyncTaskMethod()
        {
            throw new Exception("This is Task Exception.");
        }

        static async Task CallAsyncMethods()
        {
            try
            {
                AsyncVoidMethod();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Exception caught: {ex.Message}");
            }

            try
            {
                await AsyncTaskMethod();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Exception caught: {ex.Message}");
            }
        }


        #endregion
        static void Print()
        {
            Console.WriteLine("Print Method Started......");
            Task.Delay(TimeSpan.FromSeconds(5));
            Console.WriteLine("\n");
            Console.WriteLine("Print Method End");
        }
        static async void PrintAsync()
        {
            Console.WriteLine("PrintAsync Method Started......");
            await Task.Delay(TimeSpan.FromSeconds(5));
            Console.WriteLine("\n");
            Console.WriteLine("PrintAsync Method End");
        }
        public async static void SomeMethod()
        {
            Console.WriteLine("Some Method Started......");
            await Task.Delay(TimeSpan.FromSeconds(10));
            //await Wait();
            Console.WriteLine("\nSome Method End");
        }
        private static async Task Wait()
        {
            await Task.Delay(TimeSpan.FromSeconds(10));
            Console.WriteLine("\n10 Seconds wait Completed\n");
        }
        // Example of an async void method
       static async void PrintAsync1()
        {
            Console.WriteLine("Printing...");
            await Task.Delay(1000);
            Console.WriteLine("Done printing.");
        }

        // Example of an async Task method
       static async Task PrintAsync2()
        {
            Console.WriteLine("Printing...");
            await Task.Delay(1000);
            Console.WriteLine("Done printing.");
        }

        // Call the methods
                   // This is an async Task method and can be awaited


    }
}
