// ReSharper disable All

namespace OpenTl.Schema
{
	using System;
	using System.Collections;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0xa6638b9a)]
	public class TMessageActionChatCreate : IMessageAction
	{
       [SerializationOrder(0)]
       public string Itle {get; set;}

       [SerializationOrder(1)]
       public TVector<int> Users {get; set;}

	}
}
