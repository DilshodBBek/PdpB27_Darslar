using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PdpB27_Darslar._6_Dars.Enum_Struct_Generic
{
    internal struct Mystruct
    {
        public int a { get; init; }
        public int b { get; init; }
    }

    internal struct Struct1
    {
        public static void Do()
        {
            Mystruct a = new Mystruct() { a = 5, b = 6 }; 
            Mystruct b= new Mystruct() { a = 7, b = 6 };
            Console.WriteLine(a.Equals(b));
        }
    }
}
