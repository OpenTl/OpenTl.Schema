using System;
using System.IO;
using System.Reflection;

namespace OpenTl.Schema.Serialization.Serializators.Interfaces
{
    using DotNetty.Buffers;

    internal interface ISerializator
    {
        TypeInfo SupportedType { get; }
        
        void Serialize(IByteBuffer buffer, object value, SerializationMetadata metadata);
        
        object Deserialize(IByteBuffer buffer, SerializationMetadata metadata);
    }
}