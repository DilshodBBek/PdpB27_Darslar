namespace _3_Modul._1_Dars_Delegate_Event.Delegates
{
    delegate void EventStart();

    internal class DelegateExamples
    {
        public delegate bool SendSMS(string message, int phone);
        static EventStart? eventStart;
        public static void Start()
        {
            eventStart = SimpleDelegate;
            Console.WriteLine(eventStart.Target);
            Console.WriteLine(eventStart.Method.Name);

            //eventStart += Stop;
            //eventStart += ShowMoreExamples;
            //eventStart -= Stop;

            eventStart();
            //eventStart.Invoke();
        }

        public static void Stop()
        {
            Console.WriteLine();
        }
        public static void SimpleDelegate()
        {
            Console.WriteLine("this is called by eventStart delegate");
        }

        public static void ShowMoreExamples()
        {
            SMS smsObj = new();
            smsObj.sms("smsObj", 234);

            SendSMS sms = SMS.SendSmsMessage;

            sms.Invoke("this is Invoke method", 111);

            SendSMS send = new SendSMS(
                delegate (string sdsd, int sd)
            {
                Console.WriteLine(sdsd);
                return true;
            });
        }
    }
}
