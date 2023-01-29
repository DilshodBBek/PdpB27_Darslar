using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PdpB27_Darslar.Lesson7.Collections
{
    internal class HashExamples
    {
        public static void Do()
        {
            Hashtable hashtable = new();
            hashtable.Add("Anor", 20000);
            hashtable.Add("Olma", 30000);
            hashtable.Add("Olcha", 40000);
            hashtable.Add("Banan", 50000);
            //hashtable.Add("Banan", 50000);
            foreach (var item in hashtable)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();
            hashtable.Remove("Olma");
            //hashtable.Clear();
            foreach (var item in hashtable)
            {
                Console.WriteLine(item);
            }
            
        }
    }
}
