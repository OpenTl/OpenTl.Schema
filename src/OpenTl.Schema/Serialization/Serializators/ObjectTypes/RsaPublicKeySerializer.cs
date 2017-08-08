using System.IO;
using System.Reflection;
using OpenTl.Schema.Serialization.Serializators.Interfaces;

namespace OpenTl.Schema.Serialization.Serializators.ObjectTypes
 {
     internal class RsaPublicKeySerializer: ISerializator
     {
         public TypeInfo SupportedType { get; } = typeof(TRsaPublicKey).GetTypeInfo();
 
         public void Serialize(BinaryWriter writer, object value, SerializationMetadata metadata)
         {
             var rsaPublicKey = (TRsaPublicKey) value;
             
             Serializer.Serialize(rsaPublicKey.N, writer);
             Serializer.Serialize(rsaPublicKey.E, writer);
         }

         public object Deserialize(BinaryReader reader, SerializationMetadata metadata)
         {
             var rsaPublicKey = new TRsaPublicKey
            {
                N = (byte[])Serializer.Deserialize(reader, typeof(byte[]).GetTypeInfo()),
                E = (byte[])Serializer.Deserialize(reader, typeof(byte[]).GetTypeInfo())
            };

             return rsaPublicKey;
         }
     }
 }