// ReSharper disable All

namespace OpenTl.Schema
{
	using System;
	using System.Collections;
	using System.Text;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0x922aec1)]
	public class TInputMediaPhotoExternal : IInputMedia
	{
       [SerializationOrder(0)]
       public BitArray Flags {get; set;}

       [SerializationOrder(1)]
       public byte[] UrlAsBinary { get => _UrlAsBinary; set { _Url = Encoding.UTF8.GetString(value); _UrlAsBinary = value; }}
       private byte[] _UrlAsBinary;
       private string _Url;
       public string Url { get => _Url; set { UrlAsBinary = Encoding.UTF8.GetBytes(value); _Url = value; }}

       [SerializationOrder(2)]
       public byte[] CaptionAsBinary { get => _CaptionAsBinary; set { _Caption = Encoding.UTF8.GetString(value); _CaptionAsBinary = value; }}
       private byte[] _CaptionAsBinary;
       private string _Caption;
       public string Caption { get => _Caption; set { CaptionAsBinary = Encoding.UTF8.GetBytes(value); _Caption = value; }}

       [SerializationOrder(3)]
       [CanSerialize("Flags", 0)]
       public int TtlSeconds {get; set;}

	}
}
