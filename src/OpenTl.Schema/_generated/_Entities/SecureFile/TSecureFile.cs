// ReSharper disable All

namespace OpenTl.Schema
{
	using System;
	using System.Collections;
	using System.Text;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0xe0277a62)]
	public sealed class TSecureFile : ISecureFile
	{
       [SerializationOrder(0)]
       public long Id {get; set;}

       [SerializationOrder(1)]
       public long AccessHash {get; set;}

       [SerializationOrder(2)]
       public int Size {get; set;}

       [SerializationOrder(3)]
       public int DcId {get; set;}

       [SerializationOrder(4)]
       public int Date {get; set;}

       [SerializationOrder(5)]
       public byte[] FileHash {get; set;}

       [SerializationOrder(6)]
       public byte[] Secret {get; set;}

	}
}
