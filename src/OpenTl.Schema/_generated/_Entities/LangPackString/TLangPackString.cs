// ReSharper disable All

namespace OpenTl.Schema
{
	using System;
	using System.Collections;
	using System.Text;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0xcad181f6)]
	public sealed class TLangPackString : ILangPackString
	{
       /// <summary>Binary representation for the 'Key' property</summary>
       [SerializationOrder(0)]
       public byte[] KeyAsBinary { get => _KeyAsBinary; set { _Key = Encoding.UTF8.GetString(value); _KeyAsBinary = value; }}
       private byte[] _KeyAsBinary;
       private string _Key;
       public string Key { get => _Key; set { KeyAsBinary = Encoding.UTF8.GetBytes(value); _Key = value; }}

       /// <summary>Binary representation for the 'Value' property</summary>
       [SerializationOrder(1)]
       public byte[] ValueAsBinary { get => _ValueAsBinary; set { _Value = Encoding.UTF8.GetString(value); _ValueAsBinary = value; }}
       private byte[] _ValueAsBinary;
       private string _Value;
       public string Value { get => _Value; set { ValueAsBinary = Encoding.UTF8.GetBytes(value); _Value = value; }}

	}
}
