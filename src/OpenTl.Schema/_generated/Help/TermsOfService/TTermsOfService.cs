// ReSharper disable All

namespace OpenTl.Schema.Help
{
	using System;
	using System.Collections;
	using System.Text;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0xf1ee3e90)]
	public class TTermsOfService : ITermsOfService
	{
       [SerializationOrder(0)]
       public byte[] ExtAsBinary { get => _ExtAsBinary; set { _Ext = Encoding.UTF8.GetString(value); _ExtAsBinary = value; }}
       private byte[] _ExtAsBinary;
       private string _Ext;
       public string Ext { get => _Ext; set { ExtAsBinary = Encoding.UTF8.GetBytes(value); _Ext = value; }}

	}
}
