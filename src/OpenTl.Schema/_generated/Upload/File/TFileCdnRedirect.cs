// ReSharper disable All

namespace OpenTl.Schema.Upload
{
	using System;
	using System.Collections;
	using System.Text;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0xf18cda44)]
	public sealed class TFileCdnRedirect : IFile
	{
       [SerializationOrder(0)]
       public int DcId {get; set;}

       [SerializationOrder(1)]
       public byte[] FileToken {get; set;}

       [SerializationOrder(2)]
       public byte[] EncryptionKey {get; set;}

       [SerializationOrder(3)]
       public byte[] EncryptionIv {get; set;}

       [SerializationOrder(4)]
       public OpenTl.Schema.TVector<OpenTl.Schema.IFileHash> FileHashes {get; set;}

	}
}
