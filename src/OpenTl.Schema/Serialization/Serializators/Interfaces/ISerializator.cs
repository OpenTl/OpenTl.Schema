namespace OpenTl.Schema.Serialization.Serializators.Interfaces
{
    using System.Reflection;

    using DotNetty.Buffers;

    internal interface ISerializator
    {
        TypeInfo SupportedType { get; }

        object Deserialize(IByteBuffer buffer, SerializationMetadata metadata);

        void Serialize(object value, IByteBuffer buffer, SerializationMetadata metadata);
    }
}