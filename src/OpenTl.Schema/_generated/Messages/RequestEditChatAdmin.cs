// ReSharper disable All

namespace OpenTl.Schema.Messages
{
	using System;
	using System.Collections;
	using System.Text;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0xa9e69f2e)]
    public sealed class RequestEditChatAdmin : IRequest<bool>
    {
       [SerializationOrder(0)]
       public int ChatId {get; set;}

       [SerializationOrder(1)]
       public OpenTl.Schema.IInputUser UserId {get; set;}

       [SerializationOrder(2)]
       public bool IsAdmin {get; set;}

    }
}
