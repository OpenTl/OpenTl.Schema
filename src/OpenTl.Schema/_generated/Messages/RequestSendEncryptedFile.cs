// ReSharper disable All

namespace OpenTl.Schema.Messages
{
	using System;
	using System.Collections;
	using System.Text;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0x9a901b66)]
    public class RequestSendEncryptedFile : IRequest<Messages.ISentEncryptedMessage>
    {
       [SerializationOrder(0)]
       public IInputEncryptedChat Peer {get; set;}

       [SerializationOrder(1)]
       public long RandomId {get; set;}

       [SerializationOrder(2)]
       public byte[] Data {get; set;}

       [SerializationOrder(3)]
       public IInputEncryptedFile File {get; set;}

    }
}
