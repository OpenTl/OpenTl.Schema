using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using OpenTl.Schema.Serialization.Serializators.Interfaces;

namespace OpenTl.Schema.Serialization.Serializators.SimpleTypes
{
    internal class IObjectSerializer : ISerializator
    {
        public TypeInfo SupportedType { get; } = typeof(IObject).GetTypeInfo();

        public void Serialize(BinaryWriter writer, object value, SerializationMetadata metadata) => Serializer.Serialize(writer, value);

        public object Deserialize(BinaryReader reader, SerializationMetadata metadata) => Serializer.Deserialize(reader);
    }
}