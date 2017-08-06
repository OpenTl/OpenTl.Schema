// ReSharper disable All

namespace OpenTl.Schema
{
	using System;
	using System.Collections;
	using System.Text;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0xa74b15b)]
	public class TBotInlineMessageMediaAuto : IBotInlineMessage
	{
       [SerializationOrder(0)]
       public BitArray Flags {get; set;}

       [SerializationOrder(1)]
       public byte[] CaptionAsBinary { get => _CaptionAsBinary; set { _Caption = Encoding.UTF8.GetString(value); _CaptionAsBinary = value; }}
       private byte[] _CaptionAsBinary;
       private string _Caption;
       public string Caption { get => _Caption; set { CaptionAsBinary = Encoding.UTF8.GetBytes(value); _Caption = value; }}

       [SerializationOrder(2)]
       [CanSerialize("Flags", 2)]
       public IReplyMarkup ReplyMarkup {get; set;}

	}
}
