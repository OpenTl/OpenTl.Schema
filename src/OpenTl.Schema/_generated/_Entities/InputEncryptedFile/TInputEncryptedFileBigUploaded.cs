namespace OpenTl.Schema
{
	using System;
	using System.Collections;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0x2dc173c8)]
	public class TInputEncryptedFileBigUploaded : IInputEncryptedFile
	{
       [SerializationOrder(0)]
       public long Id {get; set;}

       [SerializationOrder(1)]
       public int Parts {get; set;}

       [SerializationOrder(2)]
       public int KeyFingerprint {get; set;}

	}
}
