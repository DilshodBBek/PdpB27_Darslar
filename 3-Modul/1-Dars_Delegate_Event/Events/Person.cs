namespace _3_Modul._1_Dars_Delegate_Event.Events
{
    internal class Person
    {
        public event EventHandler<SendSmsEventArgs>? OnSendSms;

        List<MessageData> AllReceivedMessages = new();
        List<MessageData> AllSentMessages = new();

        public required string OwnerName { get; set; }
        public void ShowAllReceivedMessages()
        {
            AllReceivedMessages.ForEach(x => Console.WriteLine(x));
        }

        public void ShowAllSentMessages()
        {
            AllSentMessages.ForEach(x => Console.WriteLine(x));
        }

        public void OnClickGetSms(object? sender, SendSmsEventArgs eventArgs)
        {
            AllReceivedMessages.Add(new MessageData()
            {
                smsEventArgs = eventArgs,
                Sender = sender
            });
        }

        internal void SendMessage()
        {
            Console.Write("Xabarni kiriting:");
            string smsText = Console.ReadLine() ?? "No text";
            SendSmsEventArgs eventArgs = new()
            {
                Id = 1,
                Message = smsText,
                SendDate = DateTime.Now,
            };
            OnSendSms?.Invoke(this, eventArgs);
            AllSentMessages.Add(new MessageData()
            {
                Sender = this,
                smsEventArgs = eventArgs
            });
        }

        public override string ToString()
        {
            return $"Owner: {OwnerName}";
        }
    }

    record MessageData
    {
        public object? Sender { get; set; }
        public required SendSmsEventArgs smsEventArgs { get; set; }
    }
}
