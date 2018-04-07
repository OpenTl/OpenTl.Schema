namespace OpenTl.Schema.Serialization.Serializators.SimpleTypes
{
    using System.Reflection;

    using DotNetty.Buffers;

    using OpenTl.Schema.Serialization.Serializators.Interfaces;

    internal class BooleanSerializer : ISerializator
    {
        private static readonly TBoolTrue True = new TBoolTrue();

        private static readonly TBoolFalse False = new TBoolFalse();

        public TypeInfo SupportedType { get; } = typeof(bool).GetTypeInfo();

        public object Deserialize(IByteBuffer buffer, SerializationMetadata metadata)
        {
            var serializer = SerializationMap.GetSerializator(typeof(IObject).GetTypeInfo());

            var obj = serializer.Deserialize(buffer, metadata);
            return obj is TBoolTrue;
        }

        public void Serialize(object value, IByteBuffer buffer, SerializationMetadata metadata)
        {
            var serializer = SerializationMap.GetSerializator(typeof(IObject).GetTypeInfo());
            var b = (bool)value;

            value = b
                        ? (object)True
                        : False;
            serializer.Serialize(value, buffer, metadata);
        }
    }
}