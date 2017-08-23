// ReSharper disable All

namespace OpenTl.Schema
{
    using System;
	using System.Collections;

	using OpenTl.Schema;

    public interface IPhotoSizeCommon : IObject
    {
       byte[] TypeAsBinary {get; set;}
       string Type {get; set;}

       OpenTl.Schema.IFileLocation Location {get; set;}

       int W {get; set;}

       int H {get; set;}

    }
}
