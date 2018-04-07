// ReSharper disable All

namespace OpenTl.Schema.Updates
{
	using System;
	using System.Collections;
	using System.Text;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0x3e11affb)]
	public sealed class TChannelDifferenceEmpty : IChannelDifference, IEmpty
	{
       [SerializationOrder(0)]
       public BitArray Flags {get; set;}

       [SerializationOrder(1)]
       [FromFlag("Flags", 0)]
       public bool Final {get; set;}

       [SerializationOrder(2)]
       public int Pts {get; set;}

       [SerializationOrder(3)]
       [CanSerialize("Flags", 1)]
       public int Timeout {get; set;}

	}
}
