using System.Collections;
using System.Collections.Generic;

namespace CollectionSamples
{
    public class SpecificList : IEnumerable<string>
    {
        private List<string> _collection;

        public SpecificList(List<string> collection)
        {
            _collection = collection;
        }

        public int IndexOfElementBySubstring()
        {
            //todo
            return 0;
        }

        public IEnumerator<string> GetEnumerator()
        {
            return _collection.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}