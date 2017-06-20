namespace OpenTl.Schema
{
    using System.Collections.Generic;
    using OpenTl.Schema.Serialization.Attributes;
    
    [Serialize(0x1cb5c415)]
    public class TVector<T> : IObject
    {
        [SerializationOrder(0)]
        public ICollection<T> Lists { get; set; }
    }
}    