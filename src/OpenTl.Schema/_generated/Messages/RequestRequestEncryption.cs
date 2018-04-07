// ReSharper disable All

namespace OpenTl.Schema.Messages
{
	using System;
	using System.Collections;
	using System.Text;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0xf64daf43)]
    public sealed class RequestRequestEncryption : IRequest<OpenTl.Schema.IEncryptedChat>
    {
       [SerializationOrder(0)]
       public OpenTl.Schema.IInputUser UserId {get; set;}

       [SerializationOrder(1)]
       public int RandomId {get; set;}

       [SerializationOrder(2)]
       public byte[] GA {get; set;}

    }
}
