// ReSharper disable All

namespace OpenTl.Schema
{
	using System;
	using System.Collections;
	using System.Text;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0x559ebe6d)]
	public sealed class TMessageFwdHeader : IMessageFwdHeader
	{
       [SerializationOrder(0)]
       public BitArray Flags {get; set;}

       [SerializationOrder(1)]
       [CanSerialize("Flags", 0)]
       public int FromId {get; set;}

       [SerializationOrder(2)]
       public int Date {get; set;}

       [SerializationOrder(3)]
       [CanSerialize("Flags", 1)]
       public int ChannelId {get; set;}

       [SerializationOrder(4)]
       [CanSerialize("Flags", 2)]
       public int ChannelPost {get; set;}

       /// <summary>Binary representation for the 'PostAuthor' property</summary>
       [SerializationOrder(5)]
       [CanSerialize("Flags", 3)]
       public byte[] PostAuthorAsBinary { get => _PostAuthorAsBinary; set { _PostAuthor = Encoding.UTF8.GetString(value); _PostAuthorAsBinary = value; }}
       private byte[] _PostAuthorAsBinary;
       private string _PostAuthor;
       public string PostAuthor { get => _PostAuthor; set { PostAuthorAsBinary = Encoding.UTF8.GetBytes(value); _PostAuthor = value; }}

       [SerializationOrder(6)]
       [CanSerialize("Flags", 4)]
       public OpenTl.Schema.IPeer SavedFromPeer {get; set;}

       [SerializationOrder(7)]
       [CanSerialize("Flags", 4)]
       public int SavedFromMsgId {get; set;}

	}
}
