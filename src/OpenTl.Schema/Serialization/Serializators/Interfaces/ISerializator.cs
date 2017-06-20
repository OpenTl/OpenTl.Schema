using System;
using System.IO;
using System.Reflection;

namespace OpenTl.Schema.Serialization.Serializators.Interfaces
{
    internal interface ISerializator
    {
        TypeInfo SupportedType { get; }
        
        void Serialize(BinaryWriter writer, object value, SerializationMetadata metadata);
        
        object Deserialize(BinaryReader reader, SerializationMetadata metadata);
    }
}