// ReSharper disable All

namespace OpenTl.Schema.Upload
{
	using System;
	using System.Collections;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0x1508485a)]
	public class TFileCdnRedirect : IFile
	{
       [SerializationOrder(0)]
       public int DcId {get; set;}

       [SerializationOrder(1)]
       public byte[] FileToken {get; set;}

       [SerializationOrder(2)]
       public byte[] EncryptionKey {get; set;}

       [SerializationOrder(3)]
       public byte[] EncryptionIv {get; set;}

	}
}
