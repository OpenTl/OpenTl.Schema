// ReSharper disable All

namespace OpenTl.Schema
{
	using System;
	using System.Collections;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0x1a77f29c)]
	public class TInputMediaDocument : IInputMedia
	{
       [SerializationOrder(0)]
       public IInputDocument Id {get; set;}

       [SerializationOrder(1)]
       public string Caption {get; set;}

	}
}
