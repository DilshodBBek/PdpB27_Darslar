namespace _3_Modul._1_Dars_Delegate_Event
{
    internal class LambdaExpressionExample
    {
        public delegate int MathPow<T, TKey, Tvalue, TNimadir>(int number, TNimadir obj);
           
        public delegate int MyDel();
        //static MathPow PowDelegate = Pow;
        static MathPow<int, string, double, MyDel> smsSenderPointer = (phone, MyDel) =>
        {
            int a = phone * phone;
            MyDel.Invoke();
            return a;
        };
        public static void Run()
        {
            MyDel del=Pow;
            int res = smsSenderPointer.Invoke(5, del);
            //int res = PowDelegate(5);
            Console.WriteLine(res);
        }

        public static int Pow()
        {
            return 9;
        }
    }
}
