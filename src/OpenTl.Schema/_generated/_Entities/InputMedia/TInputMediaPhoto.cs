namespace OpenTl.Schema
{
	using System;
	using System.Collections;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0xe9bfb4f3)]
	public class TInputMediaPhoto : IInputMedia
	{
       [SerializationOrder(0)]
       public IInputPhoto Id {get; set;}

       [SerializationOrder(1)]
       public string Caption {get; set;}

	}
}
