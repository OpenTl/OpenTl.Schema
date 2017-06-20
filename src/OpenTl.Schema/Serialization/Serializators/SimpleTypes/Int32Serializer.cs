using System.IO;
using System.Reflection;
using OpenTl.Schema.Serialization.Serializators.Interfaces;

namespace OpenTl.Schema.Serialization.Serializators.SimpleTypes
{
    #region Int32

    internal class Int32Serializer : ISerializator
    {
        public TypeInfo SupportedType { get; } = typeof(int).GetTypeInfo();

        public void Serialize(BinaryWriter writer, object value, SerializationMetadata metadata) => writer.Write((int) value);

        public object Deserialize(BinaryReader reader, SerializationMetadata metadata) => reader.ReadInt32();
    }

    #endregion

    #region Int64

    #endregion

    #region String

    #endregion

    #region Double

    #endregion

    #region BitArray

    #endregion
    
    #region Collection

    #endregion
    
    #region IObject

    // ReSharper disable once InconsistentNaming

    #endregion

    #region BytesArray

    #endregion
}