// ReSharper disable All

namespace OpenTl.Schema
{
	using System;
	using System.Collections;
	using System.Text;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0x292c7be9)]
	public sealed class TPageBlockEmbedPost : IPageBlock
	{
       /// <summary>Binary representation for the 'Url' property</summary>
       [SerializationOrder(0)]
       public byte[] UrlAsBinary { get => _UrlAsBinary; set { _Url = Encoding.UTF8.GetString(value); _UrlAsBinary = value; }}
       private byte[] _UrlAsBinary;
       private string _Url;
       public string Url { get => _Url; set { UrlAsBinary = Encoding.UTF8.GetBytes(value); _Url = value; }}

       [SerializationOrder(1)]
       public long WebpageId {get; set;}

       [SerializationOrder(2)]
       public long AuthorPhotoId {get; set;}

       /// <summary>Binary representation for the 'Author' property</summary>
       [SerializationOrder(3)]
       public byte[] AuthorAsBinary { get => _AuthorAsBinary; set { _Author = Encoding.UTF8.GetString(value); _AuthorAsBinary = value; }}
       private byte[] _AuthorAsBinary;
       private string _Author;
       public string Author { get => _Author; set { AuthorAsBinary = Encoding.UTF8.GetBytes(value); _Author = value; }}

       [SerializationOrder(4)]
       public int Date {get; set;}

       [SerializationOrder(5)]
       public OpenTl.Schema.TVector<OpenTl.Schema.IPageBlock> Blocks {get; set;}

       [SerializationOrder(6)]
       public OpenTl.Schema.IRichText Caption {get; set;}

	}
}
