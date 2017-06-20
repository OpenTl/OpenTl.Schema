namespace OpenTl.Schema
{
	using System;
	using System.Collections;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0x5366c915)]
	public class TPhoneCallEmpty : IPhoneCall
	{
       [SerializationOrder(0)]
       public long Id {get; set;}

	}
}
