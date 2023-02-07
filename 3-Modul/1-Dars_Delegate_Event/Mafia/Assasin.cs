using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_Modul._1_Dars_Delegate_Event.Mafia
{
    internal class Assasin
    {
        public void Task(object? sender, EventHandler eventHandler)
        {
            Console.WriteLine("Assasin completed task!");
            
            //Others others = new();           
            //others.Method1(sender, new EventArgs());
            //others.Method2(sender, new EventArgs());
            //others.Method3(sender, new EventArgs());
           
             eventHandler.Invoke(sender, new EventArgs());
        }
    }
}
