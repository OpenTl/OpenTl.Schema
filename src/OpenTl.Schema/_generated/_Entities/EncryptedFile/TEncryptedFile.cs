// ReSharper disable All

namespace OpenTl.Schema
{
	using System;
	using System.Collections;
	using System.Text;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0x4a70994c)]
	public sealed class TEncryptedFile : IEncryptedFile
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
       public int KeyFingerprint {get; set;}

	}
}
