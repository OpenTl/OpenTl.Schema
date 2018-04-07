// ReSharper disable All

namespace OpenTl.Schema
{
	using System;
	using System.Collections;
	using System.Text;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0xebe46819)]
	public sealed class TUpdateServiceNotification : IUpdate
	{
       [SerializationOrder(0)]
       public BitArray Flags {get; set;}

       [SerializationOrder(1)]
       [FromFlag("Flags", 0)]
       public bool Popup {get; set;}

       [SerializationOrder(2)]
       [CanSerialize("Flags", 1)]
       public int InboxDate {get; set;}

       /// <summary>Binary representation for the 'Type' property</summary>
       [SerializationOrder(3)]
       public byte[] TypeAsBinary { get => _TypeAsBinary; set { _Type = Encoding.UTF8.GetString(value); _TypeAsBinary = value; }}
       private byte[] _TypeAsBinary;
       private string _Type;
       public string Type { get => _Type; set { TypeAsBinary = Encoding.UTF8.GetBytes(value); _Type = value; }}

       /// <summary>Binary representation for the 'Message' property</summary>
       [SerializationOrder(4)]
       public byte[] MessageAsBinary { get => _MessageAsBinary; set { _Message = Encoding.UTF8.GetString(value); _MessageAsBinary = value; }}
       private byte[] _MessageAsBinary;
       private string _Message;
       public string Message { get => _Message; set { MessageAsBinary = Encoding.UTF8.GetBytes(value); _Message = value; }}

       [SerializationOrder(5)]
       public OpenTl.Schema.IMessageMedia Media {get; set;}

       [SerializationOrder(6)]
       public OpenTl.Schema.TVector<OpenTl.Schema.IMessageEntity> Entities {get; set;}

	}
}
