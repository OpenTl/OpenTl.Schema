using System.IO;
using System.Reflection;
using System.Text;
using OpenTl.Schema.Serialization.Serializators.Interfaces;

namespace OpenTl.Schema.Serialization.Serializators.SimpleTypes
{
    internal class StringSerializer : ISerializator
    {
        private static readonly TypeInfo BytesArrayTypeInfo = typeof(byte[]).GetTypeInfo();
        
        public TypeInfo SupportedType { get; } = typeof(string).GetTypeInfo();

        public void Serialize(BinaryWriter writer, object value, SerializationMetadata metadata) => Serializer.Serialize(SerializationUtils.GetBytes((string) value), writer);

        public object Deserialize(BinaryReader reader, SerializationMetadata metadata)
        {
            var serializator =  SerializationMap.GetSerializator(BytesArrayTypeInfo);
                
            var value = (byte[]) serializator.Deserialize(reader, metadata);

            return SerializationUtils.GetString(value);
        }
    }
}