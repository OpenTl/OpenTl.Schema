namespace OpenTl.Schema.Serialization.Serializators.SimpleTypes
{
    using System.Reflection;

    using DotNetty.Buffers;

    using OpenTl.Schema.Serialization.Serializators.Interfaces;

    internal class BytesArraySerializer : ISerializator
    {
        public TypeInfo SupportedType { get; } = typeof(byte[]).GetTypeInfo();

        public object Deserialize(IByteBuffer buffer, SerializationMetadata metadata)
        {
            byte[] data;

            if (metadata?.ArrayLength != null)
            {
                data = new byte[metadata.ArrayLength.Value];
                buffer.ReadBytes(data);

                return data;
            }

            var firstByte = buffer.ReadByte();
            int len, padding;
            if (firstByte == 254)
            {
                len = buffer.ReadByte() | (buffer.ReadByte() << 8) | (buffer.ReadByte() << 16);
                padding = len % 4;
            }
            else
            {
                len = firstByte;
                padding = (len + 1) % 4;
            }

            data = new byte[len];
            buffer.ReadBytes(data);
            if (padding > 0)
            {
                padding = 4 - padding;
                buffer.SkipBytes(padding);
            }

            return data;
        }

        public void Serialize(object value, IByteBuffer buffer, SerializationMetadata metadata)
        {
            var array = (byte[])value;

            if (metadata?.ArrayLength != null)
            {
                buffer.WriteBytes(array, 0, metadata.ArrayLength.Value);
            }
            else
            {
                int padding;
                if (array.Length < 254)
                {
                    padding = (array.Length + 1) % 4;

                    buffer.WriteByte((byte)array.Length);
                    buffer.WriteBytes(array);
                }
                else
                {
                    padding = array.Length % 4;

                    buffer.WriteByte(254);
                    buffer.WriteByte((byte)array.Length);
                    buffer.WriteByte((byte)(array.Length >> 8));
                    buffer.WriteByte((byte)(array.Length >> 16));
                    buffer.WriteBytes(array);
                }

                if (padding != 0)
                {
                    padding = 4 - padding;
                }

                for (var i = 0; i < padding; i++)
                    buffer.WriteByte(0);
            }
        }
    }
}