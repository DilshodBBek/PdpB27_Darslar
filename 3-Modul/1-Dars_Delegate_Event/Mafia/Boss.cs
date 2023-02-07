using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_Modul._1_Dars_Delegate_Event.Mafia
{
    //delegate void myDelegate(object? sender, EventArgs e);
    //delegate void EventHandler(object? sender, EventArgs e);

    //delegate void EventHandler(object? sender, EventHandler e);
    internal class Boss
    {
        public event EventHandler<EventHandler>? Order;
        EventHandler? NextOrder;
        Others others = new();
        public void start()
        {
            Console.WriteLine("Boss ordered");
            //NextOrder += others.Method1;
            //NextOrder += others.Method2;
            NextOrder += others.Method5;
            Order?.Invoke(this, NextOrder);
        }
    }
}
