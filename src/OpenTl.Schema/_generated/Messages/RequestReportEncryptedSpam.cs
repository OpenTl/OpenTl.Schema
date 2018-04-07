// ReSharper disable All

namespace OpenTl.Schema.Messages
{
	using System;
	using System.Collections;
	using System.Text;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0x4b0c8c0f)]
    public sealed class RequestReportEncryptedSpam : IRequest<bool>
    {
       [SerializationOrder(0)]
       public OpenTl.Schema.IInputEncryptedChat Peer {get; set;}

    }
}
