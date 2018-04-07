// ReSharper disable All

namespace OpenTl.Schema
{
	using System;
	using System.Collections;
	using System.Text;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0x73924be0)]
	public sealed class TMessageEntityPre : IMessageEntity
	{
       [SerializationOrder(0)]
       public int Offset {get; set;}

       [SerializationOrder(1)]
       public int Length {get; set;}

       /// <summary>Binary representation for the 'Language' property</summary>
       [SerializationOrder(2)]
       public byte[] LanguageAsBinary { get => _LanguageAsBinary; set { _Language = Encoding.UTF8.GetString(value); _LanguageAsBinary = value; }}
       private byte[] _LanguageAsBinary;
       private string _Language;
       public string Language { get => _Language; set { LanguageAsBinary = Encoding.UTF8.GetBytes(value); _Language = value; }}

	}
}
