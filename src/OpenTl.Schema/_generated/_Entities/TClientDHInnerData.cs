// ReSharper disable All

namespace OpenTl.Schema
{
	using System;
	using System.Collections;
	using System.Text;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0x6643b654)]
	public sealed class TClientDHInnerData : IObject
	{
       [SerializationArrayLength(16)]
       [SerializationOrder(0)]
       public byte[] Nonce {get; set;}

       [SerializationArrayLength(16)]
       [SerializationOrder(1)]
       public byte[] ServerNonce {get; set;}

       [SerializationOrder(2)]
       public long RetryId {get; set;}

       /// <summary>Binary representation for the 'GB' property</summary>
       [SerializationOrder(3)]
       public byte[] GBAsBinary { get => _GBAsBinary; set { _GB = Encoding.UTF8.GetString(value); _GBAsBinary = value; }}
       private byte[] _GBAsBinary;
       private string _GB;
       public string GB { get => _GB; set { GBAsBinary = Encoding.UTF8.GetBytes(value); _GB = value; }}

	}
}
