// ReSharper disable All

namespace OpenTl.Schema.Messages
{
	using System;
	using System.Collections;
	using System.Text;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0x5057c497)]
    public sealed class RequestUploadEncryptedFile : IRequest<OpenTl.Schema.IEncryptedFile>
    {
       [SerializationOrder(0)]
       public OpenTl.Schema.IInputEncryptedChat Peer {get; set;}

       [SerializationOrder(1)]
       public OpenTl.Schema.IInputEncryptedFile File {get; set;}

    }
}
