// ReSharper disable All

namespace OpenTl.Schema
{
	using System;
	using System.Collections;
	using System.Text;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0x23ab23d2)]
	public sealed class TInputMediaDocument : IInputMedia
	{
       [SerializationOrder(0)]
       public BitArray Flags {get; set;}

       [SerializationOrder(1)]
       public OpenTl.Schema.IInputDocument Id {get; set;}

       [SerializationOrder(2)]
       [CanSerialize("Flags", 0)]
       public int TtlSeconds {get; set;}

	}
}
