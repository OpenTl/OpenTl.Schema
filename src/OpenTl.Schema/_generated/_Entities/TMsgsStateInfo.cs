namespace OpenTl.Schema
{
	using System;
	using System.Collections;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0x04deb57d)]
	public class TMsgsStateInfo : IObject
	{
       [SerializationOrder(0)]
       public long ReqMsgId {get; set;}

       [SerializationOrder(1)]
       public string Info {get; set;}

	}
}
