// ReSharper disable All

namespace OpenTl.Schema
{
    using System;
	using System.Collections;

	using OpenTl.Schema;

    public interface IStickerPack : IObject
    {
        string Emoticon {get; set;}

        TVector<long> Documents {get; set;}

    }
}
