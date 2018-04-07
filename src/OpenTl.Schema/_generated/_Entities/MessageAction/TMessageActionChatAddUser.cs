// ReSharper disable All

namespace OpenTl.Schema
{
	using System;
	using System.Collections;
	using System.Text;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0x488a7337)]
	public sealed class TMessageActionChatAddUser : IMessageAction
	{
       [SerializationOrder(0)]
       public OpenTl.Schema.TVector<int> Users {get; set;}

	}
}
