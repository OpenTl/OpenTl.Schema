// ReSharper disable All

namespace OpenTl.Schema
{
	using System;
	using System.Collections;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0x11f1331c)]
	public class TUpdateShortSentMessage : IUpdates
	{
       [SerializationOrder(0)]
       public BitArray Flags {get; set;}

       [SerializationOrder(1)]
       [FromFlag("Flags", 1)]
       public bool Out {get; set;}

       [SerializationOrder(2)]
       public int Id {get; set;}

       [SerializationOrder(3)]
       public int Pts {get; set;}

       [SerializationOrder(4)]
       public int PtsCount {get; set;}

       [SerializationOrder(5)]
       public int Date {get; set;}

       [SerializationOrder(6)]
       [CanSerialize("Flags", 9)]
       public IMessageMedia Media {get; set;}

       [SerializationOrder(7)]
       [CanSerialize("Flags", 7)]
       public TVector<IMessageEntity> Entities {get; set;}

	}
}
