// ReSharper disable All

namespace OpenTl.Schema
{
    using System;
	using System.Collections;

	using OpenTl.Schema;

    public interface IStickerSetCovered : IObject
    {
       OpenTl.Schema.IStickerSet Set {get; set;}

    }
}
