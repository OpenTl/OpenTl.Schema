namespace OpenTl.Schema.Messages
{
	using System;
	using System.Collections;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0x191ba9c5)]
    public class RequestGetDialogs : IRequest<Messages.IDialogs>
    {
       [SerializationOrder(0)]
       public BitArray Flags {get; set;}

       [SerializationOrder(1)]
       [FromFlag("Flags", 0)]
       public bool ExcludePinned {get; set;}

       [SerializationOrder(2)]
       public int OffsetDate {get; set;}

       [SerializationOrder(3)]
       public int OffsetId {get; set;}

       [SerializationOrder(4)]
       public IInputPeer OffsetPeer {get; set;}

       [SerializationOrder(5)]
       public int Limit {get; set;}

    }
}
