// ReSharper disable All

namespace OpenTl.Schema.Help
{
	using System;
	using System.Collections;
	using System.Text;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0x8987f311)]
	public class TAppUpdate : IAppUpdate
	{
       [SerializationOrder(0)]
       public int Id {get; set;}

       [SerializationOrder(1)]
       public bool Critical {get; set;}

       [SerializationOrder(2)]
       public byte[] UrlAsBinary { get => _UrlAsBinary; set { _Url = Encoding.UTF8.GetString(value); _UrlAsBinary = value; }}
       private byte[] _UrlAsBinary;
       private string _Url;
       public string Url { get => _Url; set { UrlAsBinary = Encoding.UTF8.GetBytes(value); _Url = value; }}

       [SerializationOrder(3)]
       public byte[] TextAsBinary { get => _TextAsBinary; set { _Text = Encoding.UTF8.GetString(value); _TextAsBinary = value; }}
       private byte[] _TextAsBinary;
       private string _Text;
       public string Text { get => _Text; set { TextAsBinary = Encoding.UTF8.GetBytes(value); _Text = value; }}

	}
}
