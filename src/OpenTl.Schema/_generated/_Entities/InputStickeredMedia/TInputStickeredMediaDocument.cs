namespace OpenTl.Schema
{
	using System;
	using System.Collections;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0x438865b)]
	public class TInputStickeredMediaDocument : IInputStickeredMedia
	{
       [SerializationOrder(0)]
       public IInputDocument Id {get; set;}

	}
}
