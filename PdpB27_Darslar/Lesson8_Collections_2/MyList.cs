using System.Collections;

namespace PdpB27_Darslar.Lesson8_Collections_2
{
    internal class MyList<T> : IEnumerable<T>, IEnumerator<T>
    {
        private List<T> list=new List<T>();
        int position = -1;
        public T Current => list[position];

        object IEnumerator.Current => list[position];

        public MyList(params T[] values)
        {
            list = new List<T>();
            list.AddRange(values);
        }

        public MyList()
        {
            list = new List<T>();
        }
        public void Run() { Console.WriteLine("Run() worked.."); }

        public void Add(T item)
        {
             list.Add(item);
        }
        public T this[int index]
        {
            get => list[index];
            set => list[index] = value;
        }


        IEnumerator<T> IEnumerable<T>.GetEnumerator()
        {
            for (int i = 0; i < list.Count; i++)
            {
                yield return list[i];
            }
        }
        public IEnumerator GetEnumerator()
        {
            for (int i = 0; i < list.Count; i++)
            {
                yield return list[i];
            }
        }

        public bool MoveNext()
        {
           position++;
            return position < list.Count;
        }

        public void Reset()
        {
            position = -1;
        }

        public void Dispose()
        {
            Console.WriteLine();
            //throw new NotImplementedException();
        }
    }
}
