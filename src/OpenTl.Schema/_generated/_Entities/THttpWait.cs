namespace OpenTl.Schema
{
	using System;
	using System.Collections;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0x9299359f)]
	public class THttpWait : IObject
	{
       [SerializationOrder(0)]
       public int MaxDelay {get; set;}

       [SerializationOrder(1)]
       public int WaitAfter {get; set;}

       [SerializationOrder(2)]
       public int MaxWait {get; set;}

	}
}
