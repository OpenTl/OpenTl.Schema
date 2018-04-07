// ReSharper disable All

namespace OpenTl.Schema
{
	using System;
	using System.Collections;
	using System.Text;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0x44f9b43d)]
	public sealed class TMessage : IMessage
	{
       [SerializationOrder(0)]
       public BitArray Flags {get; set;}

       [SerializationOrder(1)]
       [FromFlag("Flags", 1)]
       public bool Out {get; set;}

       [SerializationOrder(2)]
       [FromFlag("Flags", 4)]
       public bool Mentioned {get; set;}

       [SerializationOrder(3)]
       [FromFlag("Flags", 5)]
       public bool MediaUnread {get; set;}

       [SerializationOrder(4)]
       [FromFlag("Flags", 13)]
       public bool Silent {get; set;}

       [SerializationOrder(5)]
       [FromFlag("Flags", 14)]
       public bool Post {get; set;}

       [SerializationOrder(6)]
       public int Id {get; set;}

       [SerializationOrder(7)]
       [CanSerialize("Flags", 8)]
       public int FromId {get; set;}

       [SerializationOrder(8)]
       public OpenTl.Schema.IPeer ToId {get; set;}

       [SerializationOrder(9)]
       [CanSerialize("Flags", 2)]
       public OpenTl.Schema.IMessageFwdHeader FwdFrom {get; set;}

       [SerializationOrder(10)]
       [CanSerialize("Flags", 11)]
       public int ViaBotId {get; set;}

       [SerializationOrder(11)]
       [CanSerialize("Flags", 3)]
       public int ReplyToMsgId {get; set;}

       [SerializationOrder(12)]
       public int Date {get; set;}

       /// <summary>Binary representation for the 'Message' property</summary>
       [SerializationOrder(13)]
       public byte[] MessageAsBinary { get => _MessageAsBinary; set { _Message = Encoding.UTF8.GetString(value); _MessageAsBinary = value; }}
       private byte[] _MessageAsBinary;
       private string _Message;
       public string Message { get => _Message; set { MessageAsBinary = Encoding.UTF8.GetBytes(value); _Message = value; }}

       [SerializationOrder(14)]
       [CanSerialize("Flags", 9)]
       public OpenTl.Schema.IMessageMedia Media {get; set;}

       [SerializationOrder(15)]
       [CanSerialize("Flags", 6)]
       public OpenTl.Schema.IReplyMarkup ReplyMarkup {get; set;}

       [SerializationOrder(16)]
       [CanSerialize("Flags", 7)]
       public OpenTl.Schema.TVector<OpenTl.Schema.IMessageEntity> Entities {get; set;}

       [SerializationOrder(17)]
       [CanSerialize("Flags", 10)]
       public int Views {get; set;}

       [SerializationOrder(18)]
       [CanSerialize("Flags", 15)]
       public int EditDate {get; set;}

       /// <summary>Binary representation for the 'PostAuthor' property</summary>
       [SerializationOrder(19)]
       [CanSerialize("Flags", 16)]
       public byte[] PostAuthorAsBinary { get => _PostAuthorAsBinary; set { _PostAuthor = Encoding.UTF8.GetString(value); _PostAuthorAsBinary = value; }}
       private byte[] _PostAuthorAsBinary;
       private string _PostAuthor;
       public string PostAuthor { get => _PostAuthor; set { PostAuthorAsBinary = Encoding.UTF8.GetBytes(value); _PostAuthor = value; }}

       [SerializationOrder(20)]
       [CanSerialize("Flags", 17)]
       public long GroupedId {get; set;}

	}
}
