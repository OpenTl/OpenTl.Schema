// ReSharper disable All

namespace OpenTl.Schema.Upload
{
	using System;
	using System.Collections;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0x21e753bc)]
	public class TWebFile : IWebFile
	{
       [SerializationOrder(0)]
       public int Size {get; set;}

       [SerializationOrder(1)]
       public string MimeType {get; set;}

       [SerializationOrder(2)]
       public Storage.IFileType FileType {get; set;}

       [SerializationOrder(3)]
       public int Mtime {get; set;}

       [SerializationArrayLength(-1)]
       [SerializationOrder(4)]
       public byte[] Bytes {get; set;}

	}
}
