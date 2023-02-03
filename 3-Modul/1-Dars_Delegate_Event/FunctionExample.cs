namespace _3_Modul._1_Dars_Delegate_Event
{
    internal class FunctionExample
    {
        delegate bool DelegateTest<T>(T test);
        public static void Run()
        {
            Func<Person, int, int> funcExample = (person, r) =>
            {
                Console.WriteLine("Func example " + person);
                return 5;
            };

            Person person = new() { id = 3, name = "Alex" };
            int result = funcExample.Invoke(person, 7);
            Console.WriteLine(result);

            Func<Action<int>, Func<int>> MyDelegate = (a) =>
            {
                a.Invoke(7);
                return () =>
                {
                    Console.WriteLine("dsg");
                    return 6;
                };
            };

            Func<int> t = MyDelegate.Invoke(Test);

        }

        public static void Test(int f)
        {
            Console.WriteLine("Bu test!");
        }
    }

    record Person
    {
        public int id;
        public string name;
    }
}
