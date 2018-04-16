using System.IO;
using System.Linq;
using DotNetty.Buffers;
using OpenTl.Schema.Help;
using OpenTl.Schema.Serialization;
using TelegramClient.Entities;
using TelegramClient.Entities.TL;
using Xunit;

namespace OpenTl.Schema.Tests
{
    public sealed class SerializeTests
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

            var buffer = Serializer.Serialize(request);

            var data = new byte[buffer.ReadableBytes];
            buffer.ReadBytes(data);
            
            buffer.ResetReaderIndex();
            var obj = (RequestInvokeWithLayer) Serializer.Deserialize(buffer);
            
            Assert.Equal(request.Layer, obj.Layer);
            Assert.NotNull(request.Query);
            Assert.IsType<RequestInitConnection>(request.Query);
        }
        
        [Fact]
        public void MsgContainer()
        {
            var container = new MsgContainer()
                       {
                           Messages = new []{ new TContainerMessage
                                              {
                                                  Body = new TPong()
                                              }, }
                       };

            var buffer =  Serializer.Serialize(container);

            Serializer.Deserialize(buffer);
        }
        
        [Fact]
        public void RsaPublicKey()
        {
            var peer = new TRsaPublicKey()
            {
                E = new byte[]{123},
                N = new byte[]{111},
            };

            var buffer =  Serializer.Serialize(peer);

            Assert.Equal(8, buffer.ReadableBytes);
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

            var buffer = Serializer.Serialize(peer);

            var obj = (TConfigSimple) Serializer.Deserialize(buffer);
            
            Assert.Equal(peer.Date, obj.Date);
            Assert.Equal(peer.IpPortList.Count, obj.IpPortList.Count);
            Assert.Equal(peer.IpPortList.First().Ipv4, obj.IpPortList.First().Ipv4);
        }
        
        [Fact]
        public void PeerUser_Serialize()
        {
            var peer = new TPeerUser()
            {
                UserId = 123
            };

            var buffer = Serializer.Serialize(peer);

            var data = new byte[buffer.ReadableBytes];
            buffer.ReadBytes(data);
            
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
            var buffer = PooledByteBufferAllocator.Default.Buffer();
            buffer.WriteBytes(data);
                
            var obj = (TPeerUser) Serializer.Deserialize(buffer);

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

            var buffer = Serializer.Serialize(callWaiting);

            var obj = (TPhoneCallWaiting)Serializer.Deserialize(buffer);
            
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