using System;
using System.Reflection;
using OpenTl.Schema.Serialization;
using Xunit;

namespace OpenTl.Schema.Tests
{
    public class SerializeTests
    {
        [Fact]
        public void TPeerUserTest()
        {
            var peer = new TPeerUser()
            {
                UserId = 123
            };

            var data = Serializer.SerializeObject(peer).ToArray();

            var obj = (TPeerUser)Serializer.DeserializeObject(data);
            
            Assert.Equal(peer.UserId, obj.UserId);
        }
        
        [Fact]
        public void TPhoneCallWaitingTest()
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
    }
}