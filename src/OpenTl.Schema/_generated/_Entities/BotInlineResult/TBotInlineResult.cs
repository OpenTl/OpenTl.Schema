// ReSharper disable All

namespace OpenTl.Schema
{
	using System;
	using System.Collections;
	using System.Text;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0x11965f3a)]
	public sealed class TBotInlineResult : IBotInlineResult
	{
       [SerializationOrder(0)]
       public BitArray Flags {get; set;}

       /// <summary>Binary representation for the 'Id' property</summary>
       [SerializationOrder(1)]
       public byte[] IdAsBinary { get => _IdAsBinary; set { _Id = Encoding.UTF8.GetString(value); _IdAsBinary = value; }}
       private byte[] _IdAsBinary;
       private string _Id;
       public string Id { get => _Id; set { IdAsBinary = Encoding.UTF8.GetBytes(value); _Id = value; }}

       /// <summary>Binary representation for the 'Type' property</summary>
       [SerializationOrder(2)]
       public byte[] TypeAsBinary { get => _TypeAsBinary; set { _Type = Encoding.UTF8.GetString(value); _TypeAsBinary = value; }}
       private byte[] _TypeAsBinary;
       private string _Type;
       public string Type { get => _Type; set { TypeAsBinary = Encoding.UTF8.GetBytes(value); _Type = value; }}

       /// <summary>Binary representation for the 'Title' property</summary>
       [SerializationOrder(3)]
       [CanSerialize("Flags", 1)]
       public byte[] TitleAsBinary { get => _TitleAsBinary; set { _Title = Encoding.UTF8.GetString(value); _TitleAsBinary = value; }}
       private byte[] _TitleAsBinary;
       private string _Title;
       public string Title { get => _Title; set { TitleAsBinary = Encoding.UTF8.GetBytes(value); _Title = value; }}

       /// <summary>Binary representation for the 'Description' property</summary>
       [SerializationOrder(4)]
       [CanSerialize("Flags", 2)]
       public byte[] DescriptionAsBinary { get => _DescriptionAsBinary; set { _Description = Encoding.UTF8.GetString(value); _DescriptionAsBinary = value; }}
       private byte[] _DescriptionAsBinary;
       private string _Description;
       public string Description { get => _Description; set { DescriptionAsBinary = Encoding.UTF8.GetBytes(value); _Description = value; }}

       /// <summary>Binary representation for the 'Url' property</summary>
       [SerializationOrder(5)]
       [CanSerialize("Flags", 3)]
       public byte[] UrlAsBinary { get => _UrlAsBinary; set { _Url = Encoding.UTF8.GetString(value); _UrlAsBinary = value; }}
       private byte[] _UrlAsBinary;
       private string _Url;
       public string Url { get => _Url; set { UrlAsBinary = Encoding.UTF8.GetBytes(value); _Url = value; }}

       [SerializationOrder(6)]
       [CanSerialize("Flags", 4)]
       public OpenTl.Schema.IWebDocument Thumb {get; set;}

       [SerializationOrder(7)]
       [CanSerialize("Flags", 5)]
       public OpenTl.Schema.IWebDocument Content {get; set;}

       [SerializationOrder(8)]
       public OpenTl.Schema.IBotInlineMessage SendMessage {get; set;}

	}
}
