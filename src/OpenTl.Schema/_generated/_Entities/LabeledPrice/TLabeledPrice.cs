namespace OpenTl.Schema
{
	using System;
	using System.Collections;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0xcb296bf8)]
	public class TLabeledPrice : ILabeledPrice
	{
       [SerializationOrder(0)]
       public string Label {get; set;}

       [SerializationOrder(1)]
       public long Amount {get; set;}

	}
}
