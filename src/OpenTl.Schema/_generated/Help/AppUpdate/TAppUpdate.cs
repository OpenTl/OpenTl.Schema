// ReSharper disable All

namespace OpenTl.Schema.Help
{
	using System;
	using System.Collections;
	using System.Text;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0x1da7158f)]
	public sealed class TAppUpdate : IAppUpdate
	{
       [SerializationOrder(0)]
       public BitArray Flags {get; set;}

       [SerializationOrder(1)]
       [FromFlag("Flags", 0)]
       public bool Popup {get; set;}

       [SerializationOrder(2)]
       public int Id {get; set;}

       /// <summary>Binary representation for the 'Version' property</summary>
       [SerializationOrder(3)]
       public byte[] VersionAsBinary { get => _VersionAsBinary; set { _Version = Encoding.UTF8.GetString(value); _VersionAsBinary = value; }}
       private byte[] _VersionAsBinary;
       private string _Version;
       public string Version { get => _Version; set { VersionAsBinary = Encoding.UTF8.GetBytes(value); _Version = value; }}

       /// <summary>Binary representation for the 'Text' property</summary>
       [SerializationOrder(4)]
       public byte[] TextAsBinary { get => _TextAsBinary; set { _Text = Encoding.UTF8.GetString(value); _TextAsBinary = value; }}
       private byte[] _TextAsBinary;
       private string _Text;
       public string Text { get => _Text; set { TextAsBinary = Encoding.UTF8.GetBytes(value); _Text = value; }}

       [SerializationOrder(5)]
       public OpenTl.Schema.TVector<OpenTl.Schema.IMessageEntity> Entities {get; set;}

       [SerializationOrder(6)]
       [CanSerialize("Flags", 1)]
       public OpenTl.Schema.IDocument Document {get; set;}

       /// <summary>Binary representation for the 'Url' property</summary>
       [SerializationOrder(7)]
       [CanSerialize("Flags", 2)]
       public byte[] UrlAsBinary { get => _UrlAsBinary; set { _Url = Encoding.UTF8.GetString(value); _UrlAsBinary = value; }}
       private byte[] _UrlAsBinary;
       private string _Url;
       public string Url { get => _Url; set { UrlAsBinary = Encoding.UTF8.GetBytes(value); _Url = value; }}

	}
}
