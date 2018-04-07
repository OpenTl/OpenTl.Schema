// ReSharper disable All

namespace OpenTl.Schema
{
	using System;
	using System.Collections;
	using System.Text;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0x2979eeb2)]
	public sealed class TLangPackStringDeleted : ILangPackString
	{
       /// <summary>Binary representation for the 'Key' property</summary>
       [SerializationOrder(0)]
       public byte[] KeyAsBinary { get => _KeyAsBinary; set { _Key = Encoding.UTF8.GetString(value); _KeyAsBinary = value; }}
       private byte[] _KeyAsBinary;
       private string _Key;
       public string Key { get => _Key; set { KeyAsBinary = Encoding.UTF8.GetBytes(value); _Key = value; }}

	}
}
