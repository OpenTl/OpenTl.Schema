// ReSharper disable All

namespace OpenTl.Schema
{
	using System;
	using System.Collections;
	using System.Text;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0x5a686d7c)]
	public sealed class TChatInviteAlready : IChatInvite
	{
       [SerializationOrder(0)]
       public OpenTl.Schema.IChat Chat {get; set;}

	}
}
