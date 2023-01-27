using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PdpB27_Darslar.Lesson9_Tuple_Nullable
{
    internal class MyGeneric<T> where T:new()
    {
        public string Id { get; set; }

        public T GetId(T id)
        {


            return id;
        }
    }
}
