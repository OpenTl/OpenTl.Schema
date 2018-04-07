// ReSharper disable All

namespace OpenTl.Schema.Messages
{
	using System;
	using System.Collections;
	using System.Text;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0x708e0195)]
    public sealed class RequestForwardMessages : IRequest<OpenTl.Schema.IUpdates>
    {
       [SerializationOrder(0)]
       public BitArray Flags {get; set;}

       [SerializationOrder(1)]
       [FromFlag("Flags", 5)]
       public bool Silent {get; set;}

       [SerializationOrder(2)]
       [FromFlag("Flags", 6)]
       public bool Background {get; set;}

       [SerializationOrder(3)]
       [FromFlag("Flags", 8)]
       public bool WithMyScore {get; set;}

       [SerializationOrder(4)]
       [FromFlag("Flags", 9)]
       public bool Grouped {get; set;}

       [SerializationOrder(5)]
       public OpenTl.Schema.IInputPeer FromPeer {get; set;}

       [SerializationOrder(6)]
       public OpenTl.Schema.TVector<int> Id {get; set;}

       [SerializationOrder(7)]
       public OpenTl.Schema.TVector<long> RandomId {get; set;}

       [SerializationOrder(8)]
       public OpenTl.Schema.IInputPeer ToPeer {get; set;}

    }
}
