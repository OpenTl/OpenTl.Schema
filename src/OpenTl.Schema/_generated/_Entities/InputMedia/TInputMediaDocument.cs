// ReSharper disable All

namespace OpenTl.Schema
{
	using System;
	using System.Collections;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0x5acb668e)]
	public class TInputMediaDocument : IInputMedia
	{
       [SerializationOrder(0)]
       public BitArray Flags {get; set;}

       [SerializationOrder(1)]
       public IInputDocument Id {get; set;}

       [SerializationOrder(2)]
       public string Caption {get; set;}

       [SerializationOrder(3)]
       [CanSerialize("Flags", 0)]
       public int TtlSeconds {get; set;}

	}
}
