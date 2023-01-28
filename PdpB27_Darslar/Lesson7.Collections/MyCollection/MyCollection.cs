using System.Collections;

namespace PdpB27_Darslar.Lesson7.Collections.MyCollection
{
    internal class MyCollection<T>
    {
        List<T> list = new List<T>();
        public void Add(T item)
        {
            list.Add(item);
        }
        public T this[int i]
        {
            get { return list[i]; }
            set { list[i] = value; }
        }

        public void Clear() { list.Clear(); }
        public bool Contains(T item)
        {
            if (list.Contains(item))
            {
                Console.WriteLine($"{item} qiymat {list.IndexOf(item)} indexda mavjud!");
                return true;
            }
            return false;
        }

        public int IndexOf(T item)
        {
            Console.WriteLine();
            return list.IndexOf(item);
        }
        public bool Remove(T item)
        {
            Console.WriteLine(item + "Qiymat o`chirildi");
           return list.Remove(item);
        }
        public void ConsoleLog()
        {
            foreach (T item in list)
            {
                Console.WriteLine("Barcha Elemntlar:");
                Console.Write(item + " ");
            }
        }

    }
}
