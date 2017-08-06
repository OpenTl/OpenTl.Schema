// ReSharper disable All

namespace OpenTl.Schema
{
	using System;
	using System.Collections;
	using System.Text;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0x258aff05)]
	public class TKeyboardButtonUrl : IKeyboardButton
	{
       [SerializationOrder(0)]
       public byte[] ExtAsBinary { get => _ExtAsBinary; set { _Ext = Encoding.UTF8.GetString(value); _ExtAsBinary = value; }}
       private byte[] _ExtAsBinary;
       private string _Ext;
       public string Ext { get => _Ext; set { ExtAsBinary = Encoding.UTF8.GetBytes(value); _Ext = value; }}

       [SerializationOrder(1)]
       public byte[] UrlAsBinary { get => _UrlAsBinary; set { _Url = Encoding.UTF8.GetString(value); _UrlAsBinary = value; }}
       private byte[] _UrlAsBinary;
       private string _Url;
       public string Url { get => _Url; set { UrlAsBinary = Encoding.UTF8.GetBytes(value); _Url = value; }}

	}
}
