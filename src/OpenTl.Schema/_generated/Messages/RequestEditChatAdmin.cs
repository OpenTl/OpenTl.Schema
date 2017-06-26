// ReSharper disable All

namespace OpenTl.Schema.Messages
{
	using System;
	using System.Collections;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0xa9e69f2e)]
    public class RequestEditChatAdmin : IRequest<bool>
    {
       [SerializationOrder(0)]
       public int ChatId {get; set;}

       [SerializationOrder(1)]
       public IInputUser UserId {get; set;}

       [SerializationOrder(2)]
       public bool IsAdmin {get; set;}

    }
}
