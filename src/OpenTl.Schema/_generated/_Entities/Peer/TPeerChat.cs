namespace OpenTl.Schema
{
	using System;
	using System.Collections;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0xbad0e5bb)]
	public class TPeerChat : IPeer
	{
       [SerializationOrder(0)]
       public int ChatId {get; set;}

	}
}
