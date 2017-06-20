namespace OpenTl.Schema
{
	using System;
	using System.Collections;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0x8cc0d131)]
	public class TMsgsAllInfo : IObject
	{
       [SerializationOrder(0)]
       public TVector<long> MsgIds {get; set;}

       [SerializationOrder(1)]
       public string Info {get; set;}

	}
}
