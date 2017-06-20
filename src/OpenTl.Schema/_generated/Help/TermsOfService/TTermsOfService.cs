namespace OpenTl.Schema.Help
{
	using System;
	using System.Collections;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0xf1ee3e90)]
	public class TTermsOfService : ITermsOfService
	{
       [SerializationOrder(0)]
       public string Ext {get; set;}

	}
}
