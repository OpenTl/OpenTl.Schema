using System.IO;
using System.Reflection;
using OpenTl.Schema.Serialization.Serializators.Interfaces;

namespace OpenTl.Schema.Serialization.Serializators.ObjectTypes
 {
     using DotNetty.Buffers;

     internal class RsaPublicKeySerializer: ISerializator
     {
         public TypeInfo SupportedType { get; } = typeof(TRsaPublicKey).GetTypeInfo();
 
         public void Serialize(IByteBuffer buffer, object value, SerializationMetadata metadata)
         {
             var rsaPublicKey = (TRsaPublicKey) value;
             
             Serializer.Serialize(rsaPublicKey.N, buffer);
             Serializer.Serialize(rsaPublicKey.E, buffer);
         }

         public object Deserialize(IByteBuffer buffer, SerializationMetadata metadata)
         {
             var rsaPublicKey = new TRsaPublicKey
            {
                N = (byte[])Serializer.DeserializeByType(buffer, typeof(byte[]).GetTypeInfo()),
                E = (byte[])Serializer.DeserializeByType(buffer, typeof(byte[]).GetTypeInfo())
            };

             return rsaPublicKey;
         }
     }
 }