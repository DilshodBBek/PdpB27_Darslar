namespace _3_Modul._1_Dars_Delegate_Event
{
    internal class ActionExample
    {
        public static void Run()
        {
            Action<string, int> PrintCosoleAction = (d, t) =>
            {
                d += "dsf"; Console.WriteLine(d);
            };
            PrintCosoleAction("Action amalda ishlash tarzi ", 4);

            Action Myaction = () =>
            {
                Console.WriteLine("sdgs");
                //db.Connect();
                //
            };
            Action<string, int> g = ActionTest;
        }

        public static void ActionTest(string a, int b)
        {

        }
    }
}
