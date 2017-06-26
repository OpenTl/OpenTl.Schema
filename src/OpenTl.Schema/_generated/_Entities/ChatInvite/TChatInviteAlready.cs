// ReSharper disable All

namespace OpenTl.Schema
{
	using System;
	using System.Collections;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0x5a686d7c)]
	public class TChatInviteAlready : IChatInvite
	{
       [SerializationOrder(0)]
       public IChat Chat {get; set;}

	}
}
