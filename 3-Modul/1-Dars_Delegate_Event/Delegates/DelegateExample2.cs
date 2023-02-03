using static _3_Modul._1_Dars_Delegate_Event.Delegates.SmsService;

namespace _3_Modul._1_Dars_Delegate_Event.Delegates
{
    internal class DelegateExample2
    {
        public static void Run()
        {
            SmsService smsService = new();
            //MyPointer pointer = smsService.Do2;
            //smsService.Do(smsService.Do2);

            bool result = smsService.SendSMS(EmailMessageSender);
        }

        static bool EmailMessageSender(string message, string address)
        {
            Console.WriteLine("Email message:'{0}'  was sent to {1}", message, address);
            return true;
        }

    }

    class SmsService
    {
        //string message = "Hello I am Donald Tramp. Time: " + DateTime.Now;

        public delegate bool EmailSenderCallback(string text, string emailAddress);

        public bool SendSMS(EmailSenderCallback callback)
        {
            Console.WriteLine("Sms message:'Hi' Phone number:'11111'");
            bool emailresult = callback.Invoke("Hi", "McDonald_Tramp@gmail.com");
            return emailresult;
        }

        public delegate void MyPointer();

        public void Do(MyPointer pointer)
        {
            Console.WriteLine("Do() worked..");
            pointer += Do3;
            pointer.Invoke();

        }

        public void Do2()
        {
            Console.WriteLine("Do2 worked..");
        }

        public void Do3()
        {
            Console.WriteLine("Do3 worked..");
        }
    }
}
