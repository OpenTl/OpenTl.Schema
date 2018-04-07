// ReSharper disable All

namespace OpenTl.Schema
{
	using System;
	using System.Collections;
	using System.Text;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0x162ecc1f)]
	public sealed class TFoundGif : IFoundGif
	{
       /// <summary>Binary representation for the 'Url' property</summary>
       [SerializationOrder(0)]
       public byte[] UrlAsBinary { get => _UrlAsBinary; set { _Url = Encoding.UTF8.GetString(value); _UrlAsBinary = value; }}
       private byte[] _UrlAsBinary;
       private string _Url;
       public string Url { get => _Url; set { UrlAsBinary = Encoding.UTF8.GetBytes(value); _Url = value; }}

       /// <summary>Binary representation for the 'ThumbUrl' property</summary>
       [SerializationOrder(1)]
       public byte[] ThumbUrlAsBinary { get => _ThumbUrlAsBinary; set { _ThumbUrl = Encoding.UTF8.GetString(value); _ThumbUrlAsBinary = value; }}
       private byte[] _ThumbUrlAsBinary;
       private string _ThumbUrl;
       public string ThumbUrl { get => _ThumbUrl; set { ThumbUrlAsBinary = Encoding.UTF8.GetBytes(value); _ThumbUrl = value; }}

       /// <summary>Binary representation for the 'ContentUrl' property</summary>
       [SerializationOrder(2)]
       public byte[] ContentUrlAsBinary { get => _ContentUrlAsBinary; set { _ContentUrl = Encoding.UTF8.GetString(value); _ContentUrlAsBinary = value; }}
       private byte[] _ContentUrlAsBinary;
       private string _ContentUrl;
       public string ContentUrl { get => _ContentUrl; set { ContentUrlAsBinary = Encoding.UTF8.GetBytes(value); _ContentUrl = value; }}

       /// <summary>Binary representation for the 'ContentType' property</summary>
       [SerializationOrder(3)]
       public byte[] ContentTypeAsBinary { get => _ContentTypeAsBinary; set { _ContentType = Encoding.UTF8.GetString(value); _ContentTypeAsBinary = value; }}
       private byte[] _ContentTypeAsBinary;
       private string _ContentType;
       public string ContentType { get => _ContentType; set { ContentTypeAsBinary = Encoding.UTF8.GetBytes(value); _ContentType = value; }}

       [SerializationOrder(4)]
       public int W {get; set;}

       [SerializationOrder(5)]
       public int H {get; set;}

	}
}
