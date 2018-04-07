// ReSharper disable All

namespace OpenTl.Schema.Messages
{
	using System;
	using System.Collections;
	using System.Text;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0x519bc2b1)]
    public sealed class RequestUploadMedia : IRequest<OpenTl.Schema.IMessageMedia>
    {
       [SerializationOrder(0)]
       public OpenTl.Schema.IInputPeer Peer {get; set;}

       [SerializationOrder(1)]
       public OpenTl.Schema.IInputMedia Media {get; set;}

    }
}
