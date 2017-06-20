namespace OpenTl.Schema
{
	using System;
	using System.Collections;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0x3c2884c1)]
	public class TTextUrl : IRichText
	{
       [SerializationOrder(0)]
       public IRichText Ext {get; set;}

       [SerializationOrder(1)]
       public string Url {get; set;}

       [SerializationOrder(2)]
       public long WebpageId {get; set;}

	}
}
