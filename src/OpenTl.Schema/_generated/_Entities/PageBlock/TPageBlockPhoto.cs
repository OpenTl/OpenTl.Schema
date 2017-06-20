namespace OpenTl.Schema
{
	using System;
	using System.Collections;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0xe9c69982)]
	public class TPageBlockPhoto : IPageBlock
	{
       [SerializationOrder(0)]
       public long PhotoId {get; set;}

       [SerializationOrder(1)]
       public IRichText Caption {get; set;}

	}
}
