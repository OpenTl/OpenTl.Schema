namespace OpenTl.Schema.Messages
{
	using System;
	using System.Collections;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0xd58f130a)]
    public class RequestSetBotCallbackAnswer : IRequest<bool>
    {
       [SerializationOrder(0)]
       public BitArray Flags {get; set;}

       [SerializationOrder(1)]
       [FromFlag("Flags", 1)]
       public bool Alert {get; set;}

       [SerializationOrder(2)]
       public long QueryId {get; set;}

       [SerializationOrder(3)]
       [CanSerialize("Flags", 0)]
       public string Message {get; set;}

       [SerializationOrder(4)]
       [CanSerialize("Flags", 2)]
       public string Url {get; set;}

       [SerializationOrder(5)]
       public int CacheTime {get; set;}

    }
}
