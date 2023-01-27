using PdpB27_Darslar.Collections;

namespace PdpB27_Darslar.Lesson9_Tuple_Nullable
{
    internal class MyCollection<T, K, U>
        where T : unmanaged
        where K : class
        where U : notnull, IDisposable, new()
        //where U : notnull
    {

        public T? TProp { get; set; }
        public K? KProp { get; set; }
        public U? UProp { get; set; }
        public T Add(T a)
        {
            Console.WriteLine("T Add warked..");
            return a;
        }

        public K GetK(K k)
        {
            Console.WriteLine("K GetK worked ...");
            //bool r = TProp.HasValue;
            return k;
        }

        public U GetU(U u)
        {
            Console.WriteLine("U GetU worked ...");   
            //((ListNode)u).val = 78;
            return u;
        }

    }
}
