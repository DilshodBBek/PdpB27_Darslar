using PdpB27_Darslar._6_Dars.Enum_Struct_Generic;
using PdpB27_Darslar.Lesson7.Collections;
using System.Collections;
using System.Data;

namespace PdpB27_Darslar.Collections
{

    public class CollectionsExamples
    {
        public static void CallCustomCollections()
        {
            MyStack myStack=new MyStack();

            myStack.Push(5);
            myStack.Push(2);
            myStack.Push(3);
            myStack.Push(7);

            Console.WriteLine(myStack.Top());
        }
        public static void ArrayListStart()
        {
            ArrayList a = new(50);
            Console.WriteLine(a.Capacity);
            int b = 5;
            object c = b;
            int d = (int)c;
            a.Add(1);
            a.Add("sadfsdf");
            Struct1 struct1 = new();
            a.Add(struct1);
            RecordName record = new("blblbla", "bar");
            a.Add(record);
            Console.WriteLine(a[3]);
            Console.WriteLine(a.IndexOf("ddddd"));
            a.Insert(2, "hello");
            a.InsertRange(2, new int[3] { 7, 9, 3 });
            a.Remove(record);
            //a.RemoveRange(1, 45);

            object[] sds = a.ToArray();
            Console.WriteLine("Capacity:" + a.Capacity);
            a.TrimToSize();
            Console.WriteLine("TrimToSize Capacity:" + a.Capacity);
            Console.WriteLine(sds.ToString());
            foreach (var item in sds)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine(a[2]);
            Console.WriteLine(a[3]);
            Console.WriteLine(a[5]);


        }

        public static void ListStart()
        {
            List<int> a = new()
            {
                45,
                23,
                235,
                56,
                123,
                34
            };

            Console.WriteLine(a[0]);
            List<int> result = a.FindAll(x => x > 20 | x < 100);

            a.ForEach(x => Console.WriteLine(x));
            List<int> b = new();
            foreach (int item in result)
            {
                Console.WriteLine(item);
            }
            a.First();

            //List<int> res=new List<int>();
            //for (int i = 0; i < a.Count; i++)
            //{
            //    if (a[i] > 20 && a[i]<100)
            //    {

            //        res.Add(a[i]);
            //    }
            //}

            //res = result
        }
        public static void LinkedListStart()
        {
            ListNode m = new ListNode(2);
            ListNode listNode = new ListNode(3);
            m.next = listNode;
            listNode.next = m;
            LinkedList<int> a = new();
            a.AddFirst(1);
            LinkedListNode<int> s = a.First;
            a.AddAfter(s, 4);
            a.AddLast(5);


        }
        public static void QueueStart()
        {
            Queue<int> m = new Queue<int>();
            m.Enqueue(1);
            m.Enqueue(2);
            m.Enqueue(3);

            Console.WriteLine(m.Dequeue());
            Console.WriteLine(m.Dequeue());
        }

        public static void StackStart()
        {
            Stack<int> m = new Stack<int>();
            Stack stack = new Stack();
            stack.Push("sdfsdfsd");

            m.Push(1);
            m.Push(2);
            m.Push(7);
            // Console.WriteLine(m.Peek());
            //Console.WriteLine(m.Pop());
            int count = m.Count;
            for (int i = 0; i < count; i++)
            {
                Console.WriteLine(m.Peek());
            }
            int[] arr=m.ToArray();
            Console.WriteLine(arr[0]);
            //foreach (var item in m)
            //{
            //    Console.WriteLine(item);
            //}
           
        }

        public static void DictionaryStart()
        {
            Dictionary<string, int> m = new();
            m.Add("Yosh bola", 1);
            m.Add("O'smir", 13);
            m.Add("Yosh avlod", 20);
            Console.WriteLine(m);
        }

        public static void HashTable()
        {
            Hashtable hashtable =new Hashtable();
            HashSet<int> keys = new HashSet<int>();

            keys.Add(1);
        }

    }
}
