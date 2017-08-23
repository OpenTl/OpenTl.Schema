// ReSharper disable All

namespace OpenTl.Schema.Messages
{
    using System;
	using System.Collections;

	using OpenTl.Schema;

    public interface IArchivedStickers : IObject
    {
       int Count {get; set;}

       OpenTl.Schema.TVector<OpenTl.Schema.IStickerSetCovered> Sets {get; set;}

    }
}
