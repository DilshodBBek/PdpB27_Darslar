using System.Collections;

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
            return (IEnumerator)GetEnumerator();
        }
        public PeopleEnum GetEnumerator()
        {
            return new PeopleEnum(_people);
        }

        //IEnumerator<int> IEnumerable<int>.GetEnumerator()
        //{
        //    throw new NotImplementedException();
        //}

    }
}
