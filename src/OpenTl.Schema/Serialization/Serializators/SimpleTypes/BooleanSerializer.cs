using System;
using System.IO;
using System.Reflection;
using OpenTl.Schema.Serialization.Serializators.Interfaces;

namespace OpenTl.Schema.Serialization.Serializators.SimpleTypes
{
    internal class BooleanSerializer : ISerializator
    {
        private static readonly TBoolTrue True = new TBoolTrue();
        private static readonly TBoolFalse False = new TBoolFalse();
        
        public TypeInfo SupportedType { get; } = typeof(bool).GetTypeInfo();

        public void Serialize(BinaryWriter writer, object value, SerializationMetadata metadata)
        {
            var b = (bool) value;

            value =  b ? (object) True : False;
            Serializer.Serialize(value, writer);
        }

        public object Deserialize(BinaryReader reader, SerializationMetadata metadata)
        {
            var obj = Serializer.Deserialize(reader, null);
            return obj is TBoolTrue;
        }
    }
}