namespace OpenTl.Schema.Messages
{
	using System;
	using System.Collections;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0xa9776773)]
    public class RequestSendEncrypted : IRequest<Messages.ISentEncryptedMessage>
    {
       [SerializationOrder(0)]
       public IInputEncryptedChat Peer {get; set;}

       [SerializationOrder(1)]
       public long RandomId {get; set;}

       [SerializationArrayLength(-1)]
       [SerializationOrder(2)]
       public byte[] Data {get; set;}

    }
}
