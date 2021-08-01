using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modul3HW2.Models;
using Modul3HW2.Models.Abstractions;

namespace Modul3HW2.Collections
{
    public class ContactCollection<T> : IReadOnlyCollection<T>
        where T : IContact
    {
        private const int DefaultCount = 4;
        private const int RateFactor = 2;

        private KeyValuePair<string, T>[] _array;
        private int _capacity;

        public ContactCollection(int capacity)
        {
            _capacity = capacity;
            _array = new KeyValuePair<string, T>[_capacity];
        }

        public ContactCollection()
            : this(DefaultCount)
        {
        }

        public int Capacity
        {
            get => _capacity;
            set
            {
                if (!ValidateSetCapacity(value))
                {
                    return;
                }

                _capacity = value;
            }
        }

        public int Count { get; private set; }

        public void Add(T item)
        {
            if (Count == Capacity)
            {
                var isSuccess = IncreaseArray();
                if (!isSuccess)
                {
                    return;
                }
            }

            AddItem(item);
        }

        public T[] GetByKey(string kay)
        {
            var i = 0;
            var newArray = new T[GetCapacity(kay)];
            foreach (var item in _array)
            {
                if (item.Key == kay)
                {
                    newArray[i] = item.Value;
                }
            }

            return newArray;
        }

        public IEnumerator<T> GetEnumerator()
        {
            return GetGenericEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
           return GetGenericEnumerator();
        }

        private int GetCapacity(string kay)
        {
            var capacity = 0;
            foreach (var item in _array)
            {
                if (item.Key == kay)
                {
                    capacity++;
                }
            }

            return capacity;
        }

        private bool IncreaseArray(int? capacity = null)
        {
            var tempArray = _array;
            if (capacity == null)
            {
                _capacity = _capacity * RateFactor;
            }
            else
            {
                var isValidCapacity = ValidateSetCapacity(capacity.Value);
                if (!isValidCapacity)
                {
                    return false;
                }

                _capacity = capacity.Value;
            }

            _array = new KeyValuePair<string, T>[Capacity];

            for (var i = 0; i < tempArray.Length; i++)
            {
                _array[i] = tempArray[i];
            }

            return true;
        }

        private void AddItem(T item)
        {
            _array[Count] = new KeyValuePair<string, T>(item.FirstName[0].ToString(), item);
            Count++;
        }

        private bool ValidateSetCapacity(int capacity)
        {
            return capacity > Count;
        }

        private IEnumerator<T> GetGenericEnumerator()
        {
            foreach (var item in _array)
            {
                if (!item.Equals(default(T)))
                {
                    yield return item.Value;
                }
            }
        }
    }
}
