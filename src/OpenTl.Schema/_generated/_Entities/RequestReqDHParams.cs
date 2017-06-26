// ReSharper disable All

namespace OpenTl.Schema
{
	using System;
	using System.Collections;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0xd712e4be)]
    public class RequestReqDHParams : IRequest<IServerDHParams>
    {
       [SerializationArrayLength(16)]
       [SerializationOrder(0)]
       public byte[] Nonce {get; set;}

       [SerializationArrayLength(16)]
       [SerializationOrder(1)]
       public byte[] ServerNonce {get; set;}

       [SerializationOrder(2)]
       public string P {get; set;}

       [SerializationOrder(3)]
       public string Q {get; set;}

       [SerializationOrder(4)]
       public long PublicKeyFingerprint {get; set;}

       [SerializationOrder(5)]
       public string EncryptedData {get; set;}

    }
}
