namespace OpenTl.Schema
{
    using System.Collections.Generic;
    using OpenTl.Schema.Serialization.Attributes;
    
    [Serialize(0x1cb5c415)]
    public class TVector<T>: IObject
    {
        public TVector()
        {
            Items = new List<T>();
        }

        public TVector(params T[] items)
        {
            Items = new List<T>(items);
        }

        public T this[int index]
        {
            get => Items[index];
            set => Items[index] = value;
        }

        public List<T> Items { get; set; }
    }
}    