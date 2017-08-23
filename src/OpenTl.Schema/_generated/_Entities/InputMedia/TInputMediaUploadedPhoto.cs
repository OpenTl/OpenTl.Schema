// ReSharper disable All

namespace OpenTl.Schema
{
	using System;
	using System.Collections;
	using System.Text;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0x2f37e231)]
	public class TInputMediaUploadedPhoto : IInputMedia
	{
       [SerializationOrder(0)]
       public BitArray Flags {get; set;}

       [SerializationOrder(1)]
       public OpenTl.Schema.IInputFile File {get; set;}

       [SerializationOrder(2)]
       public byte[] CaptionAsBinary { get => _CaptionAsBinary; set { _Caption = Encoding.UTF8.GetString(value); _CaptionAsBinary = value; }}
       private byte[] _CaptionAsBinary;
       private string _Caption;
       public string Caption { get => _Caption; set { CaptionAsBinary = Encoding.UTF8.GetBytes(value); _Caption = value; }}

       [SerializationOrder(3)]
       [CanSerialize("Flags", 0)]
       public OpenTl.Schema.TVector<OpenTl.Schema.IInputDocument> Stickers {get; set;}

       [SerializationOrder(4)]
       [CanSerialize("Flags", 1)]
       public int TtlSeconds {get; set;}

	}
}
