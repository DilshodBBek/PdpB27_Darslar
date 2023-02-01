using System.Collections;
using System.Runtime.CompilerServices;

namespace PdpB27_Darslar.Lesson8_Collections_2.IEnumerable_IEnumerator_Examples
{
    internal class People : IEnumerable
    {
        private Person[] _people;
        public People(Person[] pArray)
        {
            _people = new Person[pArray.Length];

            for (int i = 0; i < pArray.Length; i++)
            {
                _people[i] = pArray[i];
            }
        }


        // Implementation for the GetEnumerator method.
        IEnumerator IEnumerable.GetEnumerator()
        {
            yield return 3;
            yield return 5;
            yield return 6;
        }
        //public PeopleEnum GetEnumerator()
        //{
        //    return new PeopleEnum(_people);
        //}

        //IEnumerator<int> IEnumerable<int>.GetEnumerator()
        //{
        //    throw new NotImplementedException();
        //}

    }
}
