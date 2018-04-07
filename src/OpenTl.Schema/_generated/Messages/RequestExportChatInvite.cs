// ReSharper disable All

namespace OpenTl.Schema.Messages
{
	using System;
	using System.Collections;
	using System.Text;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0x7d885289)]
    public sealed class RequestExportChatInvite : IRequest<OpenTl.Schema.IExportedChatInvite>
    {
       [SerializationOrder(0)]
       public int ChatId {get; set;}

    }
}
