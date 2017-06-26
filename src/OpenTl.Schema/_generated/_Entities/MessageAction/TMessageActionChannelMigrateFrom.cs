// ReSharper disable All

namespace OpenTl.Schema
{
	using System;
	using System.Collections;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0xb055eaee)]
	public class TMessageActionChannelMigrateFrom : IMessageAction
	{
       [SerializationOrder(0)]
       public string Itle {get; set;}

       [SerializationOrder(1)]
       public int ChatId {get; set;}

	}
}
