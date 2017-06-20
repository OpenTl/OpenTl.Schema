namespace OpenTl.Schema
{
	using System;
	using System.Collections;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0x488a7337)]
	public class TMessageActionChatAddUser : IMessageAction
	{
       [SerializationOrder(0)]
       public TVector<int> Users {get; set;}

	}
}
