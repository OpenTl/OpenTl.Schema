// ReSharper disable All

namespace OpenTl.Schema.Messages
{
	using System;
	using System.Collections;
	using System.Text;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0x9a901b66)]
    public sealed class RequestSendEncryptedFile : IRequest<OpenTl.Schema.Messages.ISentEncryptedMessage>
    {
       [SerializationOrder(0)]
       public OpenTl.Schema.IInputEncryptedChat Peer {get; set;}

       [SerializationOrder(1)]
       public long RandomId {get; set;}

       [SerializationOrder(2)]
       public byte[] Data {get; set;}

       [SerializationOrder(3)]
       public OpenTl.Schema.IInputEncryptedFile File {get; set;}

    }
}
