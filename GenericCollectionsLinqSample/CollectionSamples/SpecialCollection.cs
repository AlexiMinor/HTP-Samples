using System.Collections;
using System.Collections.Generic;

namespace CollectionSamples
{
    public class SpecialIntCollection : IEnumerable<int>
    {
        private readonly List<int> _collection;

        public SpecialIntCollection(List<int> collection)
        {
            collection.Sort();
            _collection = collection;
        }

        public void Add(int item)
        {
            _collection.Add(item);
            _collection.Sort();
        }

        public IEnumerator<int> GetEnumerator()
        {
           return _collection.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}