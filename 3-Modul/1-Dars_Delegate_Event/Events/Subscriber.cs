﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_Modul._1_Dars_Delegate_Event.Events
{
    internal class Subscriber //Kosmik stanstsiya
    {
        List<(object, SendSmsEventArgs)> GetAllMessages = new();
        public void ShowAllMessages()
        {            
            foreach (var item in GetAllMessages)
            {
                Console.WriteLine(item);
            }
        }

        public void OnClickGetSms(object? sender, SendSmsEventArgs eventArgs)
        {
            GetAllMessages.Add(((sender as EventPublisher).Country, eventArgs));
        }

        internal void SendMessage()
        {
            throw new NotImplementedException();
        }
    }
}
