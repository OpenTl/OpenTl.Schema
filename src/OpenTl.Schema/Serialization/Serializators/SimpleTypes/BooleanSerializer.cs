using System;
using System.IO;
using System.Reflection;
using OpenTl.Schema.Serialization.Serializators.Interfaces;

namespace OpenTl.Schema.Serialization.Serializators.SimpleTypes
{
    using DotNetty.Buffers;

    internal class BooleanSerializer : ISerializator
    {
        private static readonly TBoolTrue True = new TBoolTrue();
        private static readonly TBoolFalse False = new TBoolFalse();
        
        public TypeInfo SupportedType { get; } = typeof(bool).GetTypeInfo();

        public void Serialize(IByteBuffer buffer, object value, SerializationMetadata metadata)
        {
            var b = (bool) value;

            value =  b ? (object) True : False;
            Serializer.Serialize(value, buffer);
        }

        public object Deserialize(IByteBuffer buffer, SerializationMetadata metadata)
        {
            var obj = Serializer.DeserializeByType(buffer, null);
            return obj is TBoolTrue;
        }
    }
}