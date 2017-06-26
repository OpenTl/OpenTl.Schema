// ReSharper disable All

namespace OpenTl.Schema.Messages
{
	using System;
	using System.Collections;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0x6c50051c)]
    public class RequestImportChatInvite : IRequest<IUpdates>
    {
       [SerializationOrder(0)]
       public string Hash {get; set;}

    }
}
