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

       [SerializationArrayLength(-1)]
       [SerializationOrder(1)]
       public byte[] FileToken {get; set;}

       [SerializationArrayLength(-1)]
       [SerializationOrder(2)]
       public byte[] EncryptionKey {get; set;}

       [SerializationArrayLength(-1)]
       [SerializationOrder(3)]
       public byte[] EncryptionIv {get; set;}

	}
}
