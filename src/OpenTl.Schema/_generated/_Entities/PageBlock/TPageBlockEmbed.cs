// ReSharper disable All

namespace OpenTl.Schema
{
	using System;
	using System.Collections;
	using System.Text;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0xcde200d1)]
	public sealed class TPageBlockEmbed : IPageBlock
	{
       [SerializationOrder(0)]
       public BitArray Flags {get; set;}

       [SerializationOrder(1)]
       [FromFlag("Flags", 0)]
       public bool FullWidth {get; set;}

       [SerializationOrder(2)]
       [FromFlag("Flags", 3)]
       public bool AllowScrolling {get; set;}

       /// <summary>Binary representation for the 'Url' property</summary>
       [SerializationOrder(3)]
       [CanSerialize("Flags", 1)]
       public byte[] UrlAsBinary { get => _UrlAsBinary; set { _Url = Encoding.UTF8.GetString(value); _UrlAsBinary = value; }}
       private byte[] _UrlAsBinary;
       private string _Url;
       public string Url { get => _Url; set { UrlAsBinary = Encoding.UTF8.GetBytes(value); _Url = value; }}

       /// <summary>Binary representation for the 'Html' property</summary>
       [SerializationOrder(4)]
       [CanSerialize("Flags", 2)]
       public byte[] HtmlAsBinary { get => _HtmlAsBinary; set { _Html = Encoding.UTF8.GetString(value); _HtmlAsBinary = value; }}
       private byte[] _HtmlAsBinary;
       private string _Html;
       public string Html { get => _Html; set { HtmlAsBinary = Encoding.UTF8.GetBytes(value); _Html = value; }}

       [SerializationOrder(5)]
       [CanSerialize("Flags", 4)]
       public long PosterPhotoId {get; set;}

       [SerializationOrder(6)]
       public int W {get; set;}

       [SerializationOrder(7)]
       public int H {get; set;}

       [SerializationOrder(8)]
       public OpenTl.Schema.IRichText Caption {get; set;}

	}
}
