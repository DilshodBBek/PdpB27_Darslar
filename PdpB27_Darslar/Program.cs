using PdpB27_Darslar.Lesson8_Collections_2;

using PdpB27_Darslar.Collections;
using PdpB27_Darslar.Lesson9_Tuple_Nullable;
using System.Collections;
using System.Runtime.CompilerServices;

namespace PdpB27_Darslar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //PdpB27_Darslar._6_Dars.Enum_Struct_Generic.Startup.Start();
            //PdpB27_Darslar.Collections.Startup.Start();
            //Startup.Lesson9Start();
           // PdpB27_Darslar.Collections.Startup.Start();
           // Lesson8.Startup();
            //Dog dog = new();
            //IAnimal animal = new Dog();
            //animal.Print();
            //ArrayList
            string s = "gd      fgd";
            int asd = 5;
            asd.MyExtension();
            Console.WriteLine(s.MyExtension());
            
        }

      
    }
    public enum ds
    {

    }
    interface IAnimal
    {
        public void Print()
        {
            Console.WriteLine("IAnimal..");
        }
    }

    static  class  Dog
    {
        public static T MyExtension<T>(this T a)
        {
            return a;
        }


    }
}
namespace System.Collections
{
    class MyCollection
    {

    }
}