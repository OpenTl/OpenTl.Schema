namespace OpenTl.Schema
{
	using System;
	using System.Collections;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0x7d748d04)]
	public class TDataJSON : IDataJSON
	{
       [SerializationOrder(0)]
       public string Data {get; set;}

	}
}
