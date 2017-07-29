// ReSharper disable All

namespace OpenTl.Schema
{
	using System;
	using System.Collections;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0x81fa373a)]
	public class TInputMediaPhoto : IInputMedia
	{
       [SerializationOrder(0)]
       public BitArray Flags {get; set;}

       [SerializationOrder(1)]
       public IInputPhoto Id {get; set;}

       [SerializationOrder(2)]
       public string Caption {get; set;}

       [SerializationOrder(3)]
       [CanSerialize("Flags", 0)]
       public int TtlSeconds {get; set;}

	}
}
