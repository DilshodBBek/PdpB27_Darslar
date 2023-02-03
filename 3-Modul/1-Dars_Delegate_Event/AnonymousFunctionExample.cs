namespace _3_Modul._1_Dars_Delegate_Event
{
    internal class AnonymousFunctionExample
    {
        public delegate TReturnType SmsServicePointer<T, TReturnType>(T number, TReturnType x) 
            where T:struct 
            where TReturnType:class;
        public static void Run()
        {
            SmsServicePointer<int,string> smsSenderPointer = delegate (int phone, string x )
            {
                return (phone * phone).ToString();
            };
            string result = smsSenderPointer.Invoke(4, "hi");
            Console.WriteLine(result);  
        }
    }
}
