using System.IO;
using System.Reflection;
using OpenTl.Schema.Serialization.Serializators.Interfaces;

namespace OpenTl.Schema.Serialization.Serializators.ObjectTypes
 {
     internal class IpPortSerializer : ISerializator
     {
         public TypeInfo SupportedType { get; } = typeof(TIpPort).GetTypeInfo();
 
         public void Serialize(BinaryWriter writer, object value, SerializationMetadata metadata)
         {
             var ipPort = (TIpPort) value;
             
             writer.Write(ipPort.Ipv4);
             writer.Write(ipPort.Port);
         }

         public object Deserialize(BinaryReader reader, SerializationMetadata metadata)
         {
            var ipPort = new TIpPort
            {
                Ipv4 = reader.ReadInt32(),
                Port = reader.ReadInt32()
            };

             return ipPort;
         }
     }
 }