using System.IO;
using System.Reflection;
using OpenTl.Schema.Serialization.Serializators.Interfaces;

namespace OpenTl.Schema.Serialization.Serializators.SimpleTypes
{
    internal class BytesArraySerializer : ISerializator
    {
        public TypeInfo SupportedType { get; } = typeof(byte[]).GetTypeInfo();

        public void Serialize(BinaryWriter writer, object value, SerializationMetadata metadata)
        {
            var array = (byte[]) value;

            if (metadata?.ArrayLength != null)
            {
                writer.Write(array, 0, metadata.ArrayLength.Value);
            }
            else
            {
                int padding;
                if (array.Length < 254)
                {
                    padding = (array.Length + 1) % 4;

                    writer.Write((byte) array.Length);
                    writer.Write(array);
                }
                else
                {
                    padding = array.Length % 4;

                    writer.Write((byte) 254);
                    writer.Write((byte) array.Length);
                    writer.Write((byte) (array.Length >> 8));
                    writer.Write((byte) (array.Length >> 16));
                    writer.Write(array);
                }

                if (padding != 0)
                    padding = 4 - padding;

                for (var i = 0; i < padding; i++)
                    writer.Write((byte) 0);
            }
        }

        public object Deserialize(BinaryReader reader, SerializationMetadata metadata)
        {
            if ( metadata?.ArrayLength != null)
            {
                return reader.ReadBytes(metadata.ArrayLength.Value);
            }
            
            var firstByte = reader.ReadByte();
            int len, padding;
            if (firstByte == 254)
            {
                len = reader.ReadByte() | (reader.ReadByte() << 8) | (reader.ReadByte() << 16);
                padding = len % 4;
            }
            else
            {
                len = firstByte;
                padding = (len + 1) % 4;
            }

            var data = reader.ReadBytes(len);
            if (padding > 0)
            {
                padding = 4 - padding;
                reader.ReadBytes(padding);
            }

            return data;
        }
    }
}