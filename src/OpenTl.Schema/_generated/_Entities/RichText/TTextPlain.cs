namespace OpenTl.Schema
{
	using System;
	using System.Collections;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0x744694e0)]
	public class TTextPlain : IRichText
	{
       [SerializationOrder(0)]
       public string Ext {get; set;}

	}
}
