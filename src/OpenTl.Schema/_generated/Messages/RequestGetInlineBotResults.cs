namespace OpenTl.Schema.Messages
{
	using System;
	using System.Collections;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0x514e999d)]
    public class RequestGetInlineBotResults : IRequest<Messages.IBotResults>
    {
       [SerializationOrder(0)]
       public BitArray Flags {get; set;}

       [SerializationOrder(1)]
       public IInputUser Bot {get; set;}

       [SerializationOrder(2)]
       public IInputPeer Peer {get; set;}

       [SerializationOrder(3)]
       [CanSerialize("Flags", 0)]
       public IInputGeoPoint GeoPoint {get; set;}

       [SerializationOrder(4)]
       public string Query {get; set;}

       [SerializationOrder(5)]
       public string Offset {get; set;}

    }
}
