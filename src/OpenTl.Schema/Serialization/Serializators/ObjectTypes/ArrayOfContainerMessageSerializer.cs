using System.Collections.Generic;
using System.IO;
using System.Reflection;
using OpenTl.Schema.Serialization.Serializators.Interfaces;

namespace OpenTl.Schema.Serialization.Serializators.ObjectTypes
{
    using DotNetty.Buffers;

    internal class ArrayOfContainerMessageSerializer : ISerializator
    {
        public TypeInfo SupportedType { get; } = typeof(TContainerMessage[]).GetTypeInfo();

        public void Serialize(IByteBuffer buffer, object value, SerializationMetadata metadata)
        {
            var array = (TContainerMessage[]) value;

            buffer.WriteIntLE(array.Length);
            foreach (var item in array)
            {
                buffer.WriteLongLE(item.MsgId);
                buffer.WriteIntLE(item.SeqNo);

                var dataBuffer = PooledByteBufferAllocator.Default.Buffer();
                try
                {
                    Serializer.Serialize(item, buffer);
                    buffer.WriteIntLE(dataBuffer.ReadableBytes);
                    buffer.WriteBytes(dataBuffer);
                }
                finally
                {
                    dataBuffer.Release();
                }
            }
        }

        public object Deserialize(IByteBuffer buffer, SerializationMetadata metadata)
        {
            var length = buffer.ReadIntLE();

            var items = new List<TContainerMessage>();
            for (var i = 0; i < length; i++)
            {
                var item = new TContainerMessage
                           {
                               MsgId = buffer.ReadLongLE(),
                               SeqNo = buffer.ReadIntLE(),
                               Bytes = buffer.ReadIntLE(),
                               Body = Serializer.Deserialize(buffer)
                           };
                items.Add(item);
            }
            return items.ToArray();
        }
    }
}