using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace SeewoHelper
{
    public partial class MonitorableList<T>
    {
        public event EventHandler<IEnumerable<T>> ElementAdded;

        public event EventHandler<IEnumerable<T>> ElementRemoved;
    }

    public partial class MonitorableList<T> : IList<T>, ICollection<T>
    {
        private readonly List<T> _list = new List<T>();

        public T this[int index] { get => _list[index]; set => _list[index] = value; }

        public int Count => _list.Count;

        bool ICollection<T>.IsReadOnly { get; } = false;

        public void Add(T item)
        {
            _list.Add(item);
            ElementAdded?.Invoke(this, new T[] { item });
        }

        public void AddRange(IEnumerable<T> items)
        {
            _list.AddRange(items);
            ElementAdded?.Invoke(this, items);
        }

        public void Clear()
        {
            var list = _list.ToList();
            _list.Clear();
            ElementRemoved?.Invoke(this, list);
        }

        public bool Contains(T item) => _list.Contains(item);

        public void CopyTo(T[] array, int arrayIndex) => _list.CopyTo(array, arrayIndex);

        public IEnumerator<T> GetEnumerator() => _list.GetEnumerator();

        public int IndexOf(T item) => _list.IndexOf(item);

        public void Insert(int index, T item)
        {
            _list.Insert(index, item);
            ElementAdded?.Invoke(this, new T[] { item });
        }

        public bool Remove(T item)
        {
            bool removed = _list.Remove(item);
            ElementRemoved?.Invoke(this, new T[] { item });
            return removed;
        }

        public int RemoveAll(Predicate<T> predicate)
        {
            if (predicate == null)
            {
                throw new ArgumentNullException(nameof(predicate));
            }

            var items = _list.Where(obj => predicate.Invoke(obj));
            int number = _list.RemoveAll(predicate);
            ElementRemoved?.Invoke(this, items);
            return number;
        }

        public void RemoveAt(int index)
        {
            var item = _list[index];
            _list.RemoveAt(index);
            ElementRemoved?.Invoke(this, new T[] { item });
        }

        public void RemoveRange(int index, int count)
        {
            var items = _list.Skip(index).Take(count);
            _list.RemoveRange(index, count);
            ElementRemoved?.Invoke(this, items);
        }

        IEnumerator IEnumerable.GetEnumerator() => _list.GetEnumerator();
    }
}
