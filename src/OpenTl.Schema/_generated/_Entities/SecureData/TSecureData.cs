// ReSharper disable All

namespace OpenTl.Schema
{
	using System;
	using System.Collections;
	using System.Text;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0x8aeabec3)]
	public sealed class TSecureData : ISecureData
	{
       [SerializationOrder(0)]
       public byte[] Data {get; set;}

       [SerializationOrder(1)]
       public byte[] DataHash {get; set;}

       [SerializationOrder(2)]
       public byte[] Secret {get; set;}

	}
}
