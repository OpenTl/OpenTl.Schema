using System.IO;
using System.Reflection;
using OpenTl.Schema.Serialization.Serializators.Interfaces;

namespace OpenTl.Schema.Serialization.Serializators.ObjectTypes
 {
     using DotNetty.Buffers;

     internal class IpPortSerializer : ISerializator
     {
         public TypeInfo SupportedType { get; } = typeof(TIpPort).GetTypeInfo();
 
         public void Serialize(IByteBuffer buffer, object value, SerializationMetadata metadata)
         {
             var ipPort = (TIpPort) value;
             
             buffer.WriteIntLE(ipPort.Ipv4);
             buffer.WriteIntLE(ipPort.Port);
         }

         public object Deserialize(IByteBuffer buffer, SerializationMetadata metadata)
         {
            var ipPort = new TIpPort
            {
                Ipv4 = buffer.ReadIntLE(),
                Port = buffer.ReadIntLE()
            };

             return ipPort;
         }
     }
 }