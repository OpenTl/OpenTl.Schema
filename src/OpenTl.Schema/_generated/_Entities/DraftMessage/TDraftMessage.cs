namespace OpenTl.Schema
{
	using System;
	using System.Collections;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0xfd8e711f)]
	public class TDraftMessage : IDraftMessage
	{
       [SerializationOrder(0)]
       public BitArray Flags {get; set;}

       [SerializationOrder(1)]
       [FromFlag("Flags", 1)]
       public bool NoWebpage {get; set;}

       [SerializationOrder(2)]
       [CanSerialize("Flags", 0)]
       public int ReplyToMsgId {get; set;}

       [SerializationOrder(3)]
       public string Message {get; set;}

       [SerializationOrder(4)]
       [CanSerialize("Flags", 3)]
       public TVector<IMessageEntity> Entities {get; set;}

       [SerializationOrder(5)]
       public int Date {get; set;}

	}
}
