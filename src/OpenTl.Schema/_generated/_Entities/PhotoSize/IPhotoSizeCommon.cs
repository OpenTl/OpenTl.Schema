// ReSharper disable All

namespace OpenTl.Schema
{
    using System;
	using System.Collections;

	using OpenTl.Schema;

    public interface IPhotoSizeCommon : IObject
    {
       byte[] YpeAsBinary {get; set;}
       string Ype {get; set;}

       IFileLocation Location {get; set;}

       int W {get; set;}

       int H {get; set;}

    }
}
