using System;
using System.Collections;
using System.Collections.Generic;

namespace CollectionSamples
{
    public class Car
    {
        
    }

    public class TaxiStation : IEnumerable<Car>
    {
        private readonly List<Car> _collection;

        public TaxiStation(List<Car> collection)
        {
            _collection = collection;
        }

        public IEnumerator<Car> GetEnumerator()
        {
            return new TaxiStationEnumerator(_collection, null);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }

    public class TaxiStationList : IList<Car>
    {
        private readonly List<Car> _collection;

        public IEnumerator<Car> GetEnumerator()
        {
            throw new NotImplementedException();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        public void Add(Car item)
        {
            throw new NotImplementedException();
        }

        public void Clear()
        {
            throw new NotImplementedException();
        }

        public bool Contains(Car item)
        {
            throw new NotImplementedException();
        }

        public void CopyTo(Car[] array, int arrayIndex)
        {
            throw new NotImplementedException();
        }

        public bool Remove(Car item)
        {
            throw new NotImplementedException();
        }

        public int Count { get; }
        public bool IsReadOnly { get; }
        public int IndexOf(Car item)
        {
            throw new NotImplementedException();
        }

        public void Insert(int index, Car item)
        {
            throw new NotImplementedException();
        }

        public void RemoveAt(int index)
        {
            throw new NotImplementedException();
        }

        public Car this[int index]
        {
            get => throw new NotImplementedException();
            set => throw new NotImplementedException();
        }
    }

    public class TaxiStationEnumerator : IEnumerator<Car>
    {
        List<Car> _collection;
        private int _position = -1;
        private readonly Car _current;

        public TaxiStationEnumerator(List<Car> collection, Car current)
        {
            _collection = collection;
            _current = current;
        }

        public bool MoveNext()
        {
            if (_position < _collection.Count)
            {
                _position++;
                return true;
            }

            return false;
        }

        public void Reset()
        {
            _position = 0;
        }

        Car IEnumerator<Car>.Current => _current;

        public object? Current
        {
            get
            {
                if (_position == -1 || _position >= _collection.Count)
                {
                    throw new IndexOutOfRangeException();
                }

                return _collection[_position];
            }

        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }
   
}