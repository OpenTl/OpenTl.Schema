// ReSharper disable All

namespace OpenTl.Schema
{
	using System;
	using System.Collections;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0xebe46819)]
	public class TUpdateServiceNotification : IUpdate
	{
       [SerializationOrder(0)]
       public BitArray Flags {get; set;}

       [SerializationOrder(1)]
       [FromFlag("Flags", 0)]
       public bool Popup {get; set;}

       [SerializationOrder(2)]
       [CanSerialize("Flags", 1)]
       public int InboxDate {get; set;}

       [SerializationOrder(3)]
       public string Type {get; set;}

       [SerializationOrder(4)]
       public string Message {get; set;}

       [SerializationOrder(5)]
       public IMessageMedia Media {get; set;}

       [SerializationOrder(6)]
       public TVector<IMessageEntity> Entities {get; set;}

	}
}
