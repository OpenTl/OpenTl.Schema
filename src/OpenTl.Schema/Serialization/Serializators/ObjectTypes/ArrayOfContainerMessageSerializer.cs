using System.Collections.Generic;
using System.IO;
using System.Reflection;
using OpenTl.Schema.Serialization.Serializators.Interfaces;

namespace OpenTl.Schema.Serialization.Serializators.ObjectTypes
{
    internal class ArrayOfContainerMessageSerializer : ISerializator
    {
        public TypeInfo SupportedType { get; } = typeof(TContainerMessage[]).GetTypeInfo();

        public void Serialize(BinaryWriter writer, object value, SerializationMetadata metadata)
        {
            var array = (TContainerMessage[]) value;

            writer.Write(array.Length);
            foreach (var item in array)
            {
                var data = Serializer.SerializeObject(item);
                writer.Write(item.MsgId);
                writer.Write(item.SeqNo);
                writer.Write(data.Length);
                writer.Write(data);
            }
        }

        public object Deserialize(BinaryReader reader, SerializationMetadata metadata)
        {
            var length = reader.ReadInt32();

            var items = new List<TContainerMessage>();
            for (var i = 0; i < length; i++)
            {
                var item = new TContainerMessage
                           {
                               MsgId = reader.ReadInt64(),
                               SeqNo = reader.ReadInt32(),
                               Bytes = reader.ReadInt32(),
                               Body = Serializer.DeserializeObject(reader)
                           };
                items.Add(item);
            }
            return items.ToArray();
        }
    }
}