namespace OpenTl.Schema.Messages
{
	using System;
	using System.Collections;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0x3eadb1bb)]
    public class RequestCheckChatInvite : IRequest<IChatInvite>
    {
       [SerializationOrder(0)]
       public string Hash {get; set;}

    }
}
