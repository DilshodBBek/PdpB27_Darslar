using System.Runtime.CompilerServices;

namespace _3_Modul.Lesson7_Multithreading.Parallelism
{
    internal static class TPL_Examples
    {
        
        
        public static async void Run()
        {
            Console.WriteLine("Run Method Started......");
            var sds = SomeMethod();
            Console.WriteLine("Run Method End");
            Console.ReadKey();  
        }
        async static Task PrintAsync()
        {

            Task task = new Task(() =>
            {
                Console.WriteLine("Action task");
            });
            task.Start();
            task.Wait();
            TaskAwaiter taskAwaiter = task.GetAwaiter();
            

            Console.WriteLine("PrintAsync Method Started......");
            SomeMethod();
            Console.WriteLine("\n");
            await Wait();
            Console.WriteLine("PrintAsync Method End");
        }
        public async static Task<string> SomeMethod()
        {
            Console.WriteLine("Some Method Started......");
            List<string> result = await GetAllUsers();
            Console.WriteLine("\nSome Method End");
            return "sdf";
        }

        private static async Task<List<string>> GetAllUsers()
        {
            List<string> users = new List<string>();
            for (int i = 1; i < 100000; i++)
            {
                users.Add("User" + i);                
            }
            return users;
        }

        private static async Task Wait()
        {
            Console.WriteLine("Wait started");
            await Task.Delay(TimeSpan.FromSeconds(2));
            Console.WriteLine("\n2 Seconds wait Completed");
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
    }
}
