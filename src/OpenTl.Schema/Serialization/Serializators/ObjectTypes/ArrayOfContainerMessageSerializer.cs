namespace OpenTl.Schema.Serialization.Serializators.ObjectTypes
{
    using System.Collections.Generic;
    using System.Reflection;

    using DotNetty.Buffers;

    using OpenTl.Schema.Serialization.Serializators.Interfaces;

    internal class ArrayOfContainerMessageSerializer : ISerializator
    {
        public TypeInfo SupportedType { get; } = typeof(TContainerMessage[]).GetTypeInfo();

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
                           };
                item.Body = Serializer.Deserialize(buffer.ReadSlice(item.Bytes));
                items.Add(item);
            }

            return items.ToArray();
        }

        public void Serialize(object value, IByteBuffer buffer, SerializationMetadata metadata)
        {
            var array = (TContainerMessage[])value;

            buffer.WriteIntLE(array.Length);
            foreach (var item in array)
            {
                buffer.WriteLongLE(item.MsgId);
                buffer.WriteIntLE(item.SeqNo);

                var dataBuffer = Serializer.Serialize(item.Body);
                try
                {
                    buffer.WriteIntLE(dataBuffer.ReadableBytes);
                    buffer.WriteBytes(dataBuffer);
                }
                finally
                {
                    dataBuffer.Release();
                }
            }
        }
    }
}