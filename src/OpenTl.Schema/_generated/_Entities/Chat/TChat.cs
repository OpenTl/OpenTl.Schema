// ReSharper disable All

namespace OpenTl.Schema
{
	using System;
	using System.Collections;
	using System.Text;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0xd91cdd54)]
	public sealed class TChat : IChat
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

       /// <summary>Binary representation for the 'Title' property</summary>
       [SerializationOrder(8)]
       public byte[] TitleAsBinary { get => _TitleAsBinary; set { _Title = Encoding.UTF8.GetString(value); _TitleAsBinary = value; }}
       private byte[] _TitleAsBinary;
       private string _Title;
       public string Title { get => _Title; set { TitleAsBinary = Encoding.UTF8.GetBytes(value); _Title = value; }}

       [SerializationOrder(9)]
       public OpenTl.Schema.IChatPhoto Photo {get; set;}

       [SerializationOrder(10)]
       public int ParticipantsCount {get; set;}

       [SerializationOrder(11)]
       public int Date {get; set;}

       [SerializationOrder(12)]
       public int Version {get; set;}

       [SerializationOrder(13)]
       [CanSerialize("Flags", 6)]
       public OpenTl.Schema.IInputChannel MigratedTo {get; set;}

	}
}
