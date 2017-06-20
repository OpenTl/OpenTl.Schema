namespace OpenTl.Schema.Contacts
{
	using System;
	using System.Collections;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0xd4982db5)]
    public class RequestGetTopPeers : IRequest<Contacts.ITopPeers>
    {
       [SerializationOrder(0)]
       public BitArray Flags {get; set;}

       [SerializationOrder(1)]
       [FromFlag("Flags", 0)]
       public bool Correspondents {get; set;}

       [SerializationOrder(2)]
       [FromFlag("Flags", 1)]
       public bool BotsPm {get; set;}

       [SerializationOrder(3)]
       [FromFlag("Flags", 2)]
       public bool BotsInline {get; set;}

       [SerializationOrder(4)]
       [FromFlag("Flags", 10)]
       public bool Groups {get; set;}

       [SerializationOrder(5)]
       [FromFlag("Flags", 15)]
       public bool Channels {get; set;}

       [SerializationOrder(6)]
       public int Offset {get; set;}

       [SerializationOrder(7)]
       public int Limit {get; set;}

       [SerializationOrder(8)]
       public int Hash {get; set;}

    }
}
