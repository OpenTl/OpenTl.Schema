// ReSharper disable All

namespace OpenTl.Schema.Messages
{
	using System;
	using System.Collections;
	using System.Text;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0x36585ea4)]
	public sealed class TBotCallbackAnswer : IBotCallbackAnswer
	{
       [SerializationOrder(0)]
       public BitArray Flags {get; set;}

       [SerializationOrder(1)]
       [FromFlag("Flags", 1)]
       public bool Alert {get; set;}

       [SerializationOrder(2)]
       [FromFlag("Flags", 3)]
       public bool HasUrl {get; set;}

       [SerializationOrder(3)]
       [FromFlag("Flags", 4)]
       public bool NativeUi {get; set;}

       /// <summary>Binary representation for the 'Message' property</summary>
       [SerializationOrder(4)]
       [CanSerialize("Flags", 0)]
       public byte[] MessageAsBinary { get => _MessageAsBinary; set { _Message = Encoding.UTF8.GetString(value); _MessageAsBinary = value; }}
       private byte[] _MessageAsBinary;
       private string _Message;
       public string Message { get => _Message; set { MessageAsBinary = Encoding.UTF8.GetBytes(value); _Message = value; }}

       /// <summary>Binary representation for the 'Url' property</summary>
       [SerializationOrder(5)]
       [CanSerialize("Flags", 2)]
       public byte[] UrlAsBinary { get => _UrlAsBinary; set { _Url = Encoding.UTF8.GetString(value); _UrlAsBinary = value; }}
       private byte[] _UrlAsBinary;
       private string _Url;
       public string Url { get => _Url; set { UrlAsBinary = Encoding.UTF8.GetBytes(value); _Url = value; }}

       [SerializationOrder(6)]
       public int CacheTime {get; set;}

	}
}
