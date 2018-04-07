// ReSharper disable All

namespace OpenTl.Schema
{
	using System;
	using System.Collections;
	using System.Text;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0x50ca4de1)]
	public sealed class TPhoneCallDiscarded : IPhoneCall
	{
       [SerializationOrder(0)]
       public BitArray Flags {get; set;}

       [SerializationOrder(1)]
       [FromFlag("Flags", 2)]
       public bool NeedRating {get; set;}

       [SerializationOrder(2)]
       [FromFlag("Flags", 3)]
       public bool NeedDebug {get; set;}

       [SerializationOrder(3)]
       public long Id {get; set;}

       [SerializationOrder(4)]
       [CanSerialize("Flags", 0)]
       public OpenTl.Schema.IPhoneCallDiscardReason Reason {get; set;}

       [SerializationOrder(5)]
       [CanSerialize("Flags", 1)]
       public int Duration {get; set;}

	}
}
