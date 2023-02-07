using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_Modul._1_Dars_Delegate_Event.Mafia
{
    internal class StartMafia
    {
        public static void Run()
        {
            Boss boss = new();

            Assasin assasin= new();

            boss.Order += assasin.Task;

            boss.start();
        }
    }
}
