// ReSharper disable All

namespace OpenTl.Schema
{
	using System;
	using System.Collections;
	using System.Text;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0x5dab1af4)]
	public sealed class TExportedMessageLink : IExportedMessageLink
	{
       /// <summary>Binary representation for the 'Link' property</summary>
       [SerializationOrder(0)]
       public byte[] LinkAsBinary { get => _LinkAsBinary; set { _Link = Encoding.UTF8.GetString(value); _LinkAsBinary = value; }}
       private byte[] _LinkAsBinary;
       private string _Link;
       public string Link { get => _Link; set { LinkAsBinary = Encoding.UTF8.GetBytes(value); _Link = value; }}

       /// <summary>Binary representation for the 'Html' property</summary>
       [SerializationOrder(1)]
       public byte[] HtmlAsBinary { get => _HtmlAsBinary; set { _Html = Encoding.UTF8.GetString(value); _HtmlAsBinary = value; }}
       private byte[] _HtmlAsBinary;
       private string _Html;
       public string Html { get => _Html; set { HtmlAsBinary = Encoding.UTF8.GetBytes(value); _Html = value; }}

	}
}
