﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_Modul._1_Dars_Delegate_Event.Events
{
    internal class Subscriber //Oy
    {
        List<(object, string)> GetAllMessages = new();
        public void ShowAllMessages()
        {            
            foreach (var item in GetAllMessages)
            {
                Console.WriteLine(item);
            }
        }

        public void OnClickSendSms(object? sender, string smsText)
        {
            GetAllMessages.Add((sender, smsText));
        }

        internal void SendMessage()
        {
            throw new NotImplementedException();
        }
    }
}
