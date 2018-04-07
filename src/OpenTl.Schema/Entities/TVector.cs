namespace OpenTl.Schema
{
    using System;
    using System.Collections;
    using System.Collections.Generic;

    using OpenTl.Schema.Serialization.Attributes;

    [Serialize(0x1cb5c415)]
    public sealed class TVector<T> : IObject,
                                     IList,
                                     IReadOnlyList<T>,
                                     IList<T>
    {
        private readonly List<T> _items;

        /// <inheritdoc cref="IList{T}" />
        public T this[int index]
        {
            get => _items[index];
            set => _items[index] = value;
        }

        /// <inheritdoc cref="IList{T}" />
        public int Count => _items.Count;

        /// <inheritdoc cref="IList" />
        public object SyncRoot => ((IList)_items).SyncRoot;

        /// <inheritdoc cref="IList" />
        public bool IsSynchronized => ((IList)_items).IsSynchronized;

        /// <inheritdoc cref="IList{T}" />
        public bool IsReadOnly => false;

        /// <inheritdoc cref="IList" />
        public bool IsFixedSize => ((IList)_items).IsFixedSize;

        object IList.this[int index]
        {
            get => ((IList)_items)[index];
            set => ((IList)_items)[index] = value;
        }

        public TVector()
        {
            _items = new List<T>();
        }

        public TVector(params T[] items)
        {
            _items = new List<T>(items);
        }

        /// <inheritdoc cref="IList{T}" />
        public void Add(T item) =>  _items.Add(item);

        /// <inheritdoc cref="IList" />
        public int Add(object value) => ((IList)_items).Add(value);

        /// <inheritdoc cref="IList{T}" />
        public void Clear() => _items.Clear();

        /// <inheritdoc cref="IList{T}" />
        public bool Contains(object value) => ((IList)_items).Contains(value);

        /// <inheritdoc />
        public bool Contains(T item) => _items.Contains(item);

        /// <inheritdoc cref="IList" />
        public void CopyTo(Array array, int index) => ((IList)_items).CopyTo(array, index);

        /// <inheritdoc cref="IList{T}" />
        public void CopyTo(T[] array, int arrayIndex) =>  _items.CopyTo(array, arrayIndex);

        /// <inheritdoc cref="IList{T}" />
        public IEnumerator<T> GetEnumerator() =>  _items.GetEnumerator();

        /// <inheritdoc cref="IList" />
        public int IndexOf(object value) => ((IList)_items).IndexOf(value);

        /// <inheritdoc cref="IList{T}" />
        public int IndexOf(T item) => _items.IndexOf(item);

        /// <inheritdoc cref="IList" />
        public void Insert(int index, object value) => ((IList)_items).Insert(index, value);

        /// <inheritdoc cref="IList{T}" />
        public void Insert(int index, T item) => _items.Insert(index, item);

        /// <inheritdoc cref="IList" />
        public void Remove(object value) => ((IList)_items).Remove(value);

        /// <inheritdoc cref="IList{T}" />
        public bool Remove(T item)  => _items.Remove(item);

        /// <inheritdoc cref="IList{T}" />
        public void RemoveAt(int index) =>  _items.RemoveAt(index);

        /// <inheritdoc cref="IList{T}" />
        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }
}