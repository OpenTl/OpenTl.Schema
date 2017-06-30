// ReSharper disable All

namespace OpenTl.Schema.Messages
{
	using System;
	using System.Collections;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0x3dbc0415)]
    public class RequestAcceptEncryption : IRequest<IEncryptedChat>
    {
       [SerializationOrder(0)]
       public IInputEncryptedChat Peer {get; set;}

       [SerializationOrder(1)]
       public byte[] GB {get; set;}

       [SerializationOrder(2)]
       public long KeyFingerprint {get; set;}

    }
}
