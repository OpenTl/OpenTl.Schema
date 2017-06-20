namespace OpenTl.Schema.Messages
{
	using System;
	using System.Collections;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0x9e3cacb0)]
    public class RequestSearchGlobal : IRequest<Messages.IMessages>
    {
       [SerializationOrder(0)]
       public string Q {get; set;}

       [SerializationOrder(1)]
       public int OffsetDate {get; set;}

       [SerializationOrder(2)]
       public IInputPeer OffsetPeer {get; set;}

       [SerializationOrder(3)]
       public int OffsetId {get; set;}

       [SerializationOrder(4)]
       public int Limit {get; set;}

    }
}
