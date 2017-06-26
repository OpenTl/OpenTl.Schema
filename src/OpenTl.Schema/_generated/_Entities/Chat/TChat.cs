// ReSharper disable All

namespace OpenTl.Schema
{
	using System;
	using System.Collections;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0xd91cdd54)]
	public class TChat : IChat
	{
       [SerializationOrder(0)]
       public BitArray Flags {get; set;}

       [SerializationOrder(1)]
       [FromFlag("Flags", 0)]
       public bool Creator {get; set;}

       [SerializationOrder(2)]
       [FromFlag("Flags", 1)]
       public bool Kicked {get; set;}

       [SerializationOrder(3)]
       [FromFlag("Flags", 2)]
       public bool Left {get; set;}

       [SerializationOrder(4)]
       [FromFlag("Flags", 3)]
       public bool AdminsEnabled {get; set;}

       [SerializationOrder(5)]
       [FromFlag("Flags", 4)]
       public bool Admin {get; set;}

       [SerializationOrder(6)]
       [FromFlag("Flags", 5)]
       public bool Deactivated {get; set;}

       [SerializationOrder(7)]
       public int Id {get; set;}

       [SerializationOrder(8)]
       public string Title {get; set;}

       [SerializationOrder(9)]
       public IChatPhoto Photo {get; set;}

       [SerializationOrder(10)]
       public int ParticipantsCount {get; set;}

       [SerializationOrder(11)]
       public int Date {get; set;}

       [SerializationOrder(12)]
       public int Version {get; set;}

       [SerializationOrder(13)]
       [CanSerialize("Flags", 6)]
       public IInputChannel MigratedTo {get; set;}

	}
}
