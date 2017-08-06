// ReSharper disable All

namespace OpenTl.Schema.Messages
{
	using System;
	using System.Collections;
	using System.Text;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0xf9a0aa09)]
    public class RequestAddChatUser : IRequest<IUpdates>
    {
       [SerializationOrder(0)]
       public int ChatId {get; set;}

       [SerializationOrder(1)]
       public IInputUser UserId {get; set;}

       [SerializationOrder(2)]
       public int FwdLimit {get; set;}

    }
}
