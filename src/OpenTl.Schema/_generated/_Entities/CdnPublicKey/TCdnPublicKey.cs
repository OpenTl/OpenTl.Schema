// ReSharper disable All

namespace OpenTl.Schema
{
	using System;
	using System.Collections;
	using System.Text;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0xc982eaba)]
	public sealed class TCdnPublicKey : ICdnPublicKey
	{
       [SerializationOrder(0)]
       public int DcId {get; set;}

       /// <summary>Binary representation for the 'PublicKey' property</summary>
       [SerializationOrder(1)]
       public byte[] PublicKeyAsBinary { get => _PublicKeyAsBinary; set { _PublicKey = Encoding.UTF8.GetString(value); _PublicKeyAsBinary = value; }}
       private byte[] _PublicKeyAsBinary;
       private string _PublicKey;
       public string PublicKey { get => _PublicKey; set { PublicKeyAsBinary = Encoding.UTF8.GetBytes(value); _PublicKey = value; }}

	}
}
