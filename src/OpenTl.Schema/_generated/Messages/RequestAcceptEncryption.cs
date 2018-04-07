// ReSharper disable All

namespace OpenTl.Schema.Messages
{
	using System;
	using System.Collections;
	using System.Text;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0x3dbc0415)]
    public sealed class RequestAcceptEncryption : IRequest<OpenTl.Schema.IEncryptedChat>
    {
       [SerializationOrder(0)]
       public OpenTl.Schema.IInputEncryptedChat Peer {get; set;}

       [SerializationOrder(1)]
       public byte[] GB {get; set;}

       [SerializationOrder(2)]
       public long KeyFingerprint {get; set;}

    }
}
