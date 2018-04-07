// ReSharper disable All

namespace OpenTl.Schema
{
	using System;
	using System.Collections;
	using System.Text;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0x5f07b4bc)]
	public sealed class TWebPage : IWebPage
	{
       [SerializationOrder(0)]
       public BitArray Flags {get; set;}

       [SerializationOrder(1)]
       public long Id {get; set;}

       /// <summary>Binary representation for the 'Url' property</summary>
       [SerializationOrder(2)]
       public byte[] UrlAsBinary { get => _UrlAsBinary; set { _Url = Encoding.UTF8.GetString(value); _UrlAsBinary = value; }}
       private byte[] _UrlAsBinary;
       private string _Url;
       public string Url { get => _Url; set { UrlAsBinary = Encoding.UTF8.GetBytes(value); _Url = value; }}

       /// <summary>Binary representation for the 'DisplayUrl' property</summary>
       [SerializationOrder(3)]
       public byte[] DisplayUrlAsBinary { get => _DisplayUrlAsBinary; set { _DisplayUrl = Encoding.UTF8.GetString(value); _DisplayUrlAsBinary = value; }}
       private byte[] _DisplayUrlAsBinary;
       private string _DisplayUrl;
       public string DisplayUrl { get => _DisplayUrl; set { DisplayUrlAsBinary = Encoding.UTF8.GetBytes(value); _DisplayUrl = value; }}

       [SerializationOrder(4)]
       public int Hash {get; set;}

       /// <summary>Binary representation for the 'Type' property</summary>
       [SerializationOrder(5)]
       [CanSerialize("Flags", 0)]
       public byte[] TypeAsBinary { get => _TypeAsBinary; set { _Type = Encoding.UTF8.GetString(value); _TypeAsBinary = value; }}
       private byte[] _TypeAsBinary;
       private string _Type;
       public string Type { get => _Type; set { TypeAsBinary = Encoding.UTF8.GetBytes(value); _Type = value; }}

       /// <summary>Binary representation for the 'SiteName' property</summary>
       [SerializationOrder(6)]
       [CanSerialize("Flags", 1)]
       public byte[] SiteNameAsBinary { get => _SiteNameAsBinary; set { _SiteName = Encoding.UTF8.GetString(value); _SiteNameAsBinary = value; }}
       private byte[] _SiteNameAsBinary;
       private string _SiteName;
       public string SiteName { get => _SiteName; set { SiteNameAsBinary = Encoding.UTF8.GetBytes(value); _SiteName = value; }}

       /// <summary>Binary representation for the 'Title' property</summary>
       [SerializationOrder(7)]
       [CanSerialize("Flags", 2)]
       public byte[] TitleAsBinary { get => _TitleAsBinary; set { _Title = Encoding.UTF8.GetString(value); _TitleAsBinary = value; }}
       private byte[] _TitleAsBinary;
       private string _Title;
       public string Title { get => _Title; set { TitleAsBinary = Encoding.UTF8.GetBytes(value); _Title = value; }}

       /// <summary>Binary representation for the 'Description' property</summary>
       [SerializationOrder(8)]
       [CanSerialize("Flags", 3)]
       public byte[] DescriptionAsBinary { get => _DescriptionAsBinary; set { _Description = Encoding.UTF8.GetString(value); _DescriptionAsBinary = value; }}
       private byte[] _DescriptionAsBinary;
       private string _Description;
       public string Description { get => _Description; set { DescriptionAsBinary = Encoding.UTF8.GetBytes(value); _Description = value; }}

       [SerializationOrder(9)]
       [CanSerialize("Flags", 4)]
       public OpenTl.Schema.IPhoto Photo {get; set;}

       /// <summary>Binary representation for the 'EmbedUrl' property</summary>
       [SerializationOrder(10)]
       [CanSerialize("Flags", 5)]
       public byte[] EmbedUrlAsBinary { get => _EmbedUrlAsBinary; set { _EmbedUrl = Encoding.UTF8.GetString(value); _EmbedUrlAsBinary = value; }}
       private byte[] _EmbedUrlAsBinary;
       private string _EmbedUrl;
       public string EmbedUrl { get => _EmbedUrl; set { EmbedUrlAsBinary = Encoding.UTF8.GetBytes(value); _EmbedUrl = value; }}

       /// <summary>Binary representation for the 'EmbedType' property</summary>
       [SerializationOrder(11)]
       [CanSerialize("Flags", 5)]
       public byte[] EmbedTypeAsBinary { get => _EmbedTypeAsBinary; set { _EmbedType = Encoding.UTF8.GetString(value); _EmbedTypeAsBinary = value; }}
       private byte[] _EmbedTypeAsBinary;
       private string _EmbedType;
       public string EmbedType { get => _EmbedType; set { EmbedTypeAsBinary = Encoding.UTF8.GetBytes(value); _EmbedType = value; }}

       [SerializationOrder(12)]
       [CanSerialize("Flags", 6)]
       public int EmbedWidth {get; set;}

       [SerializationOrder(13)]
       [CanSerialize("Flags", 6)]
       public int EmbedHeight {get; set;}

       [SerializationOrder(14)]
       [CanSerialize("Flags", 7)]
       public int Duration {get; set;}

       /// <summary>Binary representation for the 'Author' property</summary>
       [SerializationOrder(15)]
       [CanSerialize("Flags", 8)]
       public byte[] AuthorAsBinary { get => _AuthorAsBinary; set { _Author = Encoding.UTF8.GetString(value); _AuthorAsBinary = value; }}
       private byte[] _AuthorAsBinary;
       private string _Author;
       public string Author { get => _Author; set { AuthorAsBinary = Encoding.UTF8.GetBytes(value); _Author = value; }}

       [SerializationOrder(16)]
       [CanSerialize("Flags", 9)]
       public OpenTl.Schema.IDocument Document {get; set;}

       [SerializationOrder(17)]
       [CanSerialize("Flags", 10)]
       public OpenTl.Schema.IPage CachedPage {get; set;}

	}
}
