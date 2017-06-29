// ReSharper disable All

namespace OpenTl.Schema.Messages
{
    using System;
	using System.Collections;

	using OpenTl.Schema;

    public interface IStickerSet : IObject
    {
        IStickerSet Set {get; set;}

        TVector<IStickerPack> Packs {get; set;}

        TVector<IDocument> Documents {get; set;}

    }
}
