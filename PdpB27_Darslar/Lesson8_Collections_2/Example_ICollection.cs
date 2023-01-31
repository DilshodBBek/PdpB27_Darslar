using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PdpB27_Darslar.Lesson8_Collections_2
{
    internal class Example_ICollection : ICollection<int>
    {
        public int Count => throw new NotImplementedException();

        public bool IsReadOnly => throw new NotImplementedException();

        /// <summary>
        /// sgfhhhhhhhhhhhhhhhhhhh
        /// </summary>
        /// <param name="item">fsdfsdfsdfsdg</param>
        /// <returns>Bu qiymat qaytaradi </returns>
        /// <exception cref="NotImplementedException"></exception>
        public void Add(int item)
        {
            throw new NotImplementedException();
        }

        public void Clear()
        {
            throw new NotImplementedException();
        }

        public bool Contains(int item)
        {
            throw new NotImplementedException();
        }

        public void CopyTo(int[] array, int arrayIndex)
        {
            throw new NotImplementedException();
        }

        public IEnumerator<int> GetEnumerator()
        {
            throw new NotImplementedException();
        }

        public bool Remove(int item)
        {
            throw new NotImplementedException();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}
