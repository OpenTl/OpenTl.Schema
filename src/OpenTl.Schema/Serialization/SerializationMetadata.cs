using System.Reflection;

namespace OpenTl.Schema.Serialization
{
    internal class SerializationMetadata
    {
        public PropertyInfo PropertyInfo { get; set; }
        
        public TypeInfo PropertyTypeInfo { get; set; }

        public int? Order { get; set; }

        public PropertyInfo FromFlagSource { get; set; }
        
        public int? FromFlagIndex { get; set; }
        
        public PropertyInfo CanSerializeSource { get; set; }
        
        public int? CanSerializeIndex { get; set; }
        
        public int? ArrayLength { get; set; }
    }
}