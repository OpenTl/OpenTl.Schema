// ReSharper disable All

namespace OpenTl.Schema.Messages
{
    using System;
	using System.Collections;

	using OpenTl.Schema;

    public interface IStickerSet : IObject
    {
       OpenTl.Schema.IStickerSet Set {get; set;}

       OpenTl.Schema.TVector<OpenTl.Schema.IStickerPack> Packs {get; set;}

       OpenTl.Schema.TVector<OpenTl.Schema.IDocument> Documents {get; set;}

    }
}
