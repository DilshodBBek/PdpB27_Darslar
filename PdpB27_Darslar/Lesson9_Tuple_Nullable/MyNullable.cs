using PdpB27_Darslar.Collections;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PdpB27_Darslar.Lesson9_Tuple_Nullable
{
    internal class MyNullable
    {
        public static void Start()
        {
            Nullable<int> d = 5;
            //int? b = 5;

            int? a = 34;
            int? b1=null;
            
            Console.WriteLine(a<=b1);
            if (b1.HasValue)
            {
                Console.WriteLine($"b is {b1.Value}");
            }
            else
            {
                Console.WriteLine("b does not have a va"+b1.GetValueOrDefault()+"lue");
            }

            Type type =a.GetType();
            Console.WriteLine(type);
            Console.WriteLine($"int? is {(IsNullable(typeof(int?)) ? "nullable" : "non nullable")} value type");
            Console.WriteLine($"int is {(IsNullable(typeof(int)) ? "nullable" : "non-nullable")} value type");

            bool IsNullable(Type type) => Nullable.GetUnderlyingType(type) != null;

            // Output:
            // int? is nullable value type
            // int is non-nullable value type

            int? a1 = 14;
            if (a1 is int)
            {
                Console.WriteLine("int? instance is compatible with int");
            }
            ListNode? list=new ListNode();
            list.next = null;
            int? b = 17;
            if (b.HasValue)
            {
                Console.WriteLine(list.next);
                Console.WriteLine("int instance is compatible with int?");
            }
        }
    }
}
