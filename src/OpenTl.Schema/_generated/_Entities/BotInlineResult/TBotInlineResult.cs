// ReSharper disable All

namespace OpenTl.Schema
{
	using System;
	using System.Collections;
	using System.Text;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0x9bebaeb9)]
	public class TBotInlineResult : IBotInlineResult
	{
       [SerializationOrder(0)]
       public BitArray Flags {get; set;}

       [SerializationOrder(1)]
       public byte[] IdAsBinary { get => _IdAsBinary; set { _Id = Encoding.UTF8.GetString(value); _IdAsBinary = value; }}
       private byte[] _IdAsBinary;
       private string _Id;
       public string Id { get => _Id; set { IdAsBinary = Encoding.UTF8.GetBytes(value); _Id = value; }}

       [SerializationOrder(2)]
       public byte[] TypeAsBinary { get => _TypeAsBinary; set { _Type = Encoding.UTF8.GetString(value); _TypeAsBinary = value; }}
       private byte[] _TypeAsBinary;
       private string _Type;
       public string Type { get => _Type; set { TypeAsBinary = Encoding.UTF8.GetBytes(value); _Type = value; }}

       [SerializationOrder(3)]
       [CanSerialize("Flags", 1)]
       public byte[] TitleAsBinary { get => _TitleAsBinary; set { _Title = Encoding.UTF8.GetString(value); _TitleAsBinary = value; }}
       private byte[] _TitleAsBinary;
       private string _Title;
       public string Title { get => _Title; set { TitleAsBinary = Encoding.UTF8.GetBytes(value); _Title = value; }}

       [SerializationOrder(4)]
       [CanSerialize("Flags", 2)]
       public byte[] DescriptionAsBinary { get => _DescriptionAsBinary; set { _Description = Encoding.UTF8.GetString(value); _DescriptionAsBinary = value; }}
       private byte[] _DescriptionAsBinary;
       private string _Description;
       public string Description { get => _Description; set { DescriptionAsBinary = Encoding.UTF8.GetBytes(value); _Description = value; }}

       [SerializationOrder(5)]
       [CanSerialize("Flags", 3)]
       public byte[] UrlAsBinary { get => _UrlAsBinary; set { _Url = Encoding.UTF8.GetString(value); _UrlAsBinary = value; }}
       private byte[] _UrlAsBinary;
       private string _Url;
       public string Url { get => _Url; set { UrlAsBinary = Encoding.UTF8.GetBytes(value); _Url = value; }}

       [SerializationOrder(6)]
       [CanSerialize("Flags", 4)]
       public byte[] ThumbUrlAsBinary { get => _ThumbUrlAsBinary; set { _ThumbUrl = Encoding.UTF8.GetString(value); _ThumbUrlAsBinary = value; }}
       private byte[] _ThumbUrlAsBinary;
       private string _ThumbUrl;
       public string ThumbUrl { get => _ThumbUrl; set { ThumbUrlAsBinary = Encoding.UTF8.GetBytes(value); _ThumbUrl = value; }}

       [SerializationOrder(7)]
       [CanSerialize("Flags", 5)]
       public byte[] ContentUrlAsBinary { get => _ContentUrlAsBinary; set { _ContentUrl = Encoding.UTF8.GetString(value); _ContentUrlAsBinary = value; }}
       private byte[] _ContentUrlAsBinary;
       private string _ContentUrl;
       public string ContentUrl { get => _ContentUrl; set { ContentUrlAsBinary = Encoding.UTF8.GetBytes(value); _ContentUrl = value; }}

       [SerializationOrder(8)]
       [CanSerialize("Flags", 5)]
       public byte[] ContentTypeAsBinary { get => _ContentTypeAsBinary; set { _ContentType = Encoding.UTF8.GetString(value); _ContentTypeAsBinary = value; }}
       private byte[] _ContentTypeAsBinary;
       private string _ContentType;
       public string ContentType { get => _ContentType; set { ContentTypeAsBinary = Encoding.UTF8.GetBytes(value); _ContentType = value; }}

       [SerializationOrder(9)]
       [CanSerialize("Flags", 6)]
       public int W {get; set;}

       [SerializationOrder(10)]
       [CanSerialize("Flags", 6)]
       public int H {get; set;}

       [SerializationOrder(11)]
       [CanSerialize("Flags", 7)]
       public int Duration {get; set;}

       [SerializationOrder(12)]
       public IBotInlineMessage SendMessage {get; set;}

	}
}
