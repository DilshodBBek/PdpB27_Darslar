using PdpB27_Darslar._6_Dars.Enum_Struct_Generic;
using PdpB27_Darslar.Collections;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PdpB27_Darslar.Lesson9_Tuple_Nullable
{
    internal class Startup
    {
        public static void Lesson9Start()
        {
            //TupleExamples.TupleMain();

            MyNullable.Start();
            ListNode listNode= new ListNode();  

            
           // MyGeneric<ListNode> myGeneric= new MyGeneric<ListNode>();

            MyCollection<int, string, ListNode> myCollection = new();

            Console.WriteLine(myCollection.Add(3));
            Console.WriteLine(myCollection.GetK("bu K parametr"));
            Console.WriteLine(myCollection.GetU(new ListNode(56)).val);
            
        }
    }
}
