namespace _3_Modul._1_Dars_Delegate_Event.Delegates
{
    internal class DelegateExample2
    {
        public static void Run()
        {
            SmsService smsService = new();
            bool result = smsService.SendSMS(901112233, EmailMessageSender);
        }

        static bool EmailMessageSender(string message, string address)
        {
            Console.WriteLine("Email message:'{0}'  was sent to {1}", message, address);
            return true;
        }

    }

    class SmsService
    {
        string message = "Hello I am Donald Tramp. Time: " + DateTime.Now;

        public delegate bool EmailSenderCallback(string text, string emailAddress);

        public bool SendSMS(int phone, EmailSenderCallback callback)
        {
            Console.WriteLine("Sms message:'{0}' Phone number:'{1}'", message, phone);
            bool emailresult = callback.Invoke(message, "McDonald_Tramp@gmail.com");
            return emailresult;
        }
    }
}
