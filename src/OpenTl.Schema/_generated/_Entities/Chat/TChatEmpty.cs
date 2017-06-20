namespace OpenTl.Schema
{
	using System;
	using System.Collections;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0x9ba2d800)]
	public class TChatEmpty : IChat
	{
       [SerializationOrder(0)]
       public int Id {get; set;}

	}
}
