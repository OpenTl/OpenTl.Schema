// ReSharper disable All

namespace OpenTl.Schema.Messages
{
	using System;
	using System.Collections;
	using System.Text;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0xca4c79d8)]
    public sealed class RequestEditChatPhoto : IRequest<OpenTl.Schema.IUpdates>
    {
       [SerializationOrder(0)]
       public int ChatId {get; set;}

       [SerializationOrder(1)]
       public OpenTl.Schema.IInputChatPhoto Photo {get; set;}

    }
}
