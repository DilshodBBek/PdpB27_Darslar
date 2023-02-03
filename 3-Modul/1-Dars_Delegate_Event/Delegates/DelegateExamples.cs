namespace _3_Modul._1_Dars_Delegate_Event.Delegates
{
    delegate void EventStart();

    internal class DelegateExamples
    {
        public static void Start()
        {
            EventStart eventStart = SimpleDelegate;
            EventStart start = ShowMoreExamples;
            start += SimpleDelegate;
            //eventStart();

            EventStart eventStart1 = eventStart + start;
            eventStart1.Invoke();
            //eventStart.Invoke();
            Console.WriteLine(eventStart.Target);
            Console.WriteLine(eventStart.Method);

            //eventStart += Stop;

            //eventStart.Invoke();
        }
        public static void SimpleDelegate()
        {
            Console.WriteLine("SimpleDelegate();");
        }

        public delegate bool SendSMS(string message, int phone);
        
        public static  void ShowMoreExamples()
        {
            Console.WriteLine("ShowMoreExamples");
            //SMS smsObj = new();

            //smsObj.sms("smsObj", 234);

            //SMS.SendSmsMessage("smsObj", 234);

            //SendSMS sms = SMS.SendSmsMessage;
            ////sms+=SendSMS
            //bool res = sms("this is Invoke method", 111);

            //SendSMS send = new SendSMS(
            //    delegate (string sdsd, int sd)
            //{
            //    Console.WriteLine(sdsd);
            //    return true;
            //});
        }
        public static void Stop()
        {
            Console.WriteLine("Stop()");
        }
    }
}
