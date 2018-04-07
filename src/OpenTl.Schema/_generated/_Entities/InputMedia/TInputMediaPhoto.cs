// ReSharper disable All

namespace OpenTl.Schema
{
	using System;
	using System.Collections;
	using System.Text;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0xb3ba0635)]
	public sealed class TInputMediaPhoto : IInputMedia
	{
       [SerializationOrder(0)]
       public BitArray Flags {get; set;}

       [SerializationOrder(1)]
       public OpenTl.Schema.IInputPhoto Id {get; set;}

       [SerializationOrder(2)]
       [CanSerialize("Flags", 0)]
       public int TtlSeconds {get; set;}

	}
}
