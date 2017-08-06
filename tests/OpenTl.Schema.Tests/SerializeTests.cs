using System.IO;
using System.Linq;
using OpenTl.Schema.Help;
using OpenTl.Schema.Serialization;
using TelegramClient.Entities;
using TelegramClient.Entities.TL;
using Xunit;

namespace OpenTl.Schema.Tests
{
    public class SerializeTests
    {
        [Fact]
        public void RequestInvokeWithLayer_Serialize()
        {
            var request = new RequestInvokeWithLayer
            {
                Layer = SchemaInfo.SchemaVersion,
                Query = new RequestInitConnection
                {
                    ApiId = 123123123,
                    AppVersion = "1.0.0",
                    DeviceModel = "PC",
                    LangCode = "en",
                    LangPack = "en",
                    SystemLangCode = "en",
                    Query = new RequestGetConfig(),
                    SystemVersion = "Win 10.0"
                }
            };

            var data = Serializer.SerializeObject(request).ToArray();
            
            var legacy = (RequestInvokeWithLayer) LegacyDeserialize(data);

            var obj = (RequestInvokeWithLayer) Serializer.DeserializeObject(data);
            
            Assert.Equal(request.Layer, obj.Layer);
            Assert.Equal(request.Query, obj.Query);
        }
        
        [Fact]
        public void ConfigSimple_Serialize()
        {
            var peer = new TConfigSimple()
            {
                Date = 123,
                DcId = 432,
                Expires = 3213,
                IpPortList = new TVector<TIpPort>(new TIpPort{Ipv4 = 444, Port = 555})
            };

            var data = Serializer.SerializeObject(peer).ToArray();

            var obj = (TConfigSimple) Serializer.DeserializeObject(data);
            
            Assert.Equal(peer.Date, obj.Date);
        }
        
        [Fact]
        public void PeerUser_Serialize()
        {
            var peer = new TPeerUser()
            {
                UserId = 123
            };

            var data = Serializer.SerializeObject(peer).ToArray();

            var obj = (TlPeerUser) LegacyDeserialize(data);
            
            Assert.Equal(peer.UserId, obj.UserId);
        }
        
        [Fact]
        public void PeerUser_Deserialize()
        {
            var peer = new TlPeerUser()
            {
                UserId = 123
            };

            var data = LegacySerialize(peer);
            
            var obj = (TPeerUser) Serializer.DeserializeObject(data);

            Assert.Equal(peer.UserId, obj.UserId);
        }

        [Fact]
        public void PhoneCallWaiting_Self()
        {
            var callWaiting = new TPhoneCallWaiting()
            {
                AccessHash = 123,
                AdminId = 456,
                Date = 543,
                Id = 12345,
                ParticipantId = 456666,
                ReceiveDate = 555,
                Protocol = new TPhoneCallProtocol
                {
                    MaxLayer = 111,
                    MinLayer = 222,
                    UdpP2p = true,
                    UdpReflector = true
                },
            };

            var data = Serializer.SerializeObject(callWaiting).ToArray();

            var obj = (TPhoneCallWaiting)Serializer.DeserializeObject(data);
            
            Assert.Equal(callWaiting.AccessHash, obj.AccessHash);
            Assert.Equal(callWaiting.AdminId, obj.AdminId);
            Assert.Equal(callWaiting.Date, obj.Date);
            Assert.Equal(callWaiting.Id, obj.Id);
            Assert.Equal(callWaiting.ParticipantId, obj.ParticipantId);
            Assert.Equal(callWaiting.ReceiveDate, obj.ReceiveDate);
            Assert.Equal(((TPhoneCallProtocol)callWaiting.Protocol).MaxLayer, ((TPhoneCallProtocol)obj.Protocol).MaxLayer);
            Assert.Equal(((TPhoneCallProtocol)callWaiting.Protocol).MinLayer, ((TPhoneCallProtocol)obj.Protocol).MinLayer);
            Assert.Equal(((TPhoneCallProtocol)callWaiting.Protocol).UdpP2p, ((TPhoneCallProtocol)obj.Protocol).UdpP2p);
            Assert.Equal(((TPhoneCallProtocol)callWaiting.Protocol).UdpReflector, ((TPhoneCallProtocol)obj.Protocol).UdpReflector);
        }
        

        private static object LegacyDeserialize(byte[] data)
        {
            using (var stream = new MemoryStream(data))
            using (var reader = new BinaryReader(stream))
            {
                return ObjectUtils.DeserializeObject(reader);
            }
        }

        private static byte[] LegacySerialize(TlPeerUser peer)
        {
            using (var stream = new MemoryStream())
            using (var reader = new BinaryWriter(stream))
            {
                ObjectUtils.SerializeObject(peer, reader);

                return stream.ToArray();
            }
        }

     
    }
}