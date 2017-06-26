// ReSharper disable All

namespace OpenTl.Schema
{
	using System;
	using System.Collections;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0x95d2ac92)]
	public class TMessageActionChannelCreate : IMessageAction
	{
       [SerializationOrder(0)]
       public string Itle {get; set;}

	}
}
