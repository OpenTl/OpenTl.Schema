// ReSharper disable All

namespace OpenTl.Schema.Upload
{
	using System;
	using System.Collections;
	using System.Text;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0x96a18d5)]
	public sealed class TFile : IFile
	{
       [SerializationOrder(0)]
       public OpenTl.Schema.Storage.IFileType Type {get; set;}

       [SerializationOrder(1)]
       public int Mtime {get; set;}

       [SerializationOrder(2)]
       public byte[] Bytes {get; set;}

	}
}
