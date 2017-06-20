namespace OpenTl.Schema.Messages
{
	using System;
	using System.Collections;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0xf64daf43)]
    public class RequestRequestEncryption : IRequest<IEncryptedChat>
    {
       [SerializationOrder(0)]
       public IInputUser UserId {get; set;}

       [SerializationOrder(1)]
       public int RandomId {get; set;}

       [SerializationArrayLength(-1)]
       [SerializationOrder(2)]
       public byte[] GA {get; set;}

    }
}
