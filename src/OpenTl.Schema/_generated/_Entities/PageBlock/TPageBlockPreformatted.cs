// ReSharper disable All

namespace OpenTl.Schema
{
	using System;
	using System.Collections;
	using System.Text;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0xc070d93e)]
	public sealed class TPageBlockPreformatted : IPageBlock
	{
       [SerializationOrder(0)]
       public OpenTl.Schema.IRichText Text {get; set;}

       /// <summary>Binary representation for the 'Language' property</summary>
       [SerializationOrder(1)]
       public byte[] LanguageAsBinary { get => _LanguageAsBinary; set { _Language = Encoding.UTF8.GetString(value); _LanguageAsBinary = value; }}
       private byte[] _LanguageAsBinary;
       private string _Language;
       public string Language { get => _Language; set { LanguageAsBinary = Encoding.UTF8.GetBytes(value); _Language = value; }}

	}
}
