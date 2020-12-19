using System;
using System.Collections;
using System.Collections.Generic;

namespace SeewoHelper
{
    public partial class DisposableCollection : IDisposable
    {
        public T Add<T>(T item)
            where T : IDisposable
        {
            _disposables.Add(item);
            return item;
        }

        public void Dispose()
        {
            foreach (var disposable in _disposables)
            {
                disposable.Dispose();
            }
        }
    }

    public partial class DisposableCollection : ICollection<IDisposable>
    {
        private List<IDisposable> _disposables = new List<IDisposable>();

        public int Count => _disposables.Count;

        public bool IsReadOnly { get; } = false;

        void ICollection<IDisposable>.Add(IDisposable item) => _disposables.Add(item);

        public void Clear() => _disposables.Clear();

        public bool Contains(IDisposable item) => _disposables.Contains(item);

        public void CopyTo(IDisposable[] array, int arrayIndex) => _disposables.CopyTo(array, arrayIndex);

        public IEnumerator<IDisposable> GetEnumerator() => _disposables.GetEnumerator();

        public bool Remove(IDisposable item) => _disposables.Remove(item);

        IEnumerator IEnumerable.GetEnumerator() => _disposables.GetEnumerator();
    }
}
