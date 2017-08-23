// ReSharper disable All

namespace OpenTl.Schema
{
    using System;
	using System.Collections;

	using OpenTl.Schema;

    public interface IStickerPack : IObject
    {
       byte[] EmoticonAsBinary {get; set;}
       string Emoticon {get; set;}

       OpenTl.Schema.TVector<long> Documents {get; set;}

    }
}
