// ReSharper disable All

namespace OpenTl.Schema
{
	using System;
	using System.Collections;
	using System.Text;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0xa2bb35cb)]
	public sealed class TPhoneCallProtocol : IPhoneCallProtocol
	{
       [SerializationOrder(0)]
       public BitArray Flags {get; set;}

       [SerializationOrder(1)]
       [FromFlag("Flags", 0)]
       public bool UdpP2p {get; set;}

       [SerializationOrder(2)]
       [FromFlag("Flags", 1)]
       public bool UdpReflector {get; set;}

       [SerializationOrder(3)]
       public int MinLayer {get; set;}

       [SerializationOrder(4)]
       public int MaxLayer {get; set;}

	}
}
