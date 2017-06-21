using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using OpenTl.Schema.Serialization.Serializators.Interfaces;

namespace OpenTl.Schema.Serialization.Serializators.SimpleTypes
{
    internal class CollectionSerializer : ISerializator
    {
        public TypeInfo SupportedType { get; } = typeof(ICollection).GetTypeInfo();

        public void Serialize(BinaryWriter writer, object value, SerializationMetadata metadata)
        {
            var collection = (ICollection) value;
            writer.Write(collection.Count);
            
            foreach (var item in collection)
            {
                Serializer.Serialize(item, writer);
            }
        }

        public object Deserialize(BinaryReader reader, SerializationMetadata metadata)
        {
            var length = reader.ReadInt32();
            var listType = typeof(List<>).MakeGenericType(metadata.PropertyTypeInfo.GenericTypeArguments[0]);
            var children = (IList) Activator.CreateInstance(listType);
            for (var j = 0; j < length; j++)
            {
                var child = Serializer.Deserialize(reader);
                children.Add(child);
            }

            return children;
        }
    }
}