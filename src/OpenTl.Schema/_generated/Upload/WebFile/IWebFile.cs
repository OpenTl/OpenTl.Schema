// ReSharper disable All

namespace OpenTl.Schema.Upload
{
    using System;
	using System.Collections;

	using OpenTl.Schema;

    public interface IWebFile : IObject
    {
       int Size {get; set;}

       byte[] MimeTypeAsBinary {get; set;}
       string MimeType {get; set;}

       OpenTl.Schema.Storage.IFileType FileType {get; set;}

       int Mtime {get; set;}

       byte[] Bytes {get; set;}

    }
}
