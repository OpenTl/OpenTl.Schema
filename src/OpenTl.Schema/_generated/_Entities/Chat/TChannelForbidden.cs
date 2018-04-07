// ReSharper disable All

namespace OpenTl.Schema
{
	using System;
	using System.Collections;
	using System.Text;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0x289da732)]
	public sealed class TChannelForbidden : IChat
	{
       [SerializationOrder(0)]
       public BitArray Flags {get; set;}

       [SerializationOrder(1)]
       [FromFlag("Flags", 5)]
       public bool Broadcast {get; set;}

       [SerializationOrder(2)]
       [FromFlag("Flags", 8)]
       public bool Megagroup {get; set;}

       [SerializationOrder(3)]
       public int Id {get; set;}

       [SerializationOrder(4)]
       public long AccessHash {get; set;}

       /// <summary>Binary representation for the 'Title' property</summary>
       [SerializationOrder(5)]
       public byte[] TitleAsBinary { get => _TitleAsBinary; set { _Title = Encoding.UTF8.GetString(value); _TitleAsBinary = value; }}
       private byte[] _TitleAsBinary;
       private string _Title;
       public string Title { get => _Title; set { TitleAsBinary = Encoding.UTF8.GetBytes(value); _Title = value; }}

       [SerializationOrder(6)]
       [CanSerialize("Flags", 16)]
       public int UntilDate {get; set;}

	}
}
