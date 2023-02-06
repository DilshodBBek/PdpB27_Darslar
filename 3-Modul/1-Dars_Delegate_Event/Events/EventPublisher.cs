using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_Modul._1_Dars_Delegate_Event.Events
{
    //delegate void ClickSendSms(object? sender, string smsText, DateTime d, Name n);

    
    internal class EventPublisher //Yer
    {
        //List<(object, string)> AllMessages = new();
        public event EventHandler<SendSmsEventArgs>? OnClickSendSms;

        public required string Country { get; set; }
        public void SendSmsMessage()
        {
            Console.Write("Xabarni kiriting:");
            string smsText = Console.ReadLine() ?? "No text";
            SendSmsEventArgs eventArgs = new()
            {
                Id = 1,
                Message = smsText,
                SendDate = DateTime.Now,
            };
            OnClickSendSms?.Invoke(this, eventArgs);
        }

        internal void ShowAllMessages()
        {
            throw new NotImplementedException();
        }
    }
}
