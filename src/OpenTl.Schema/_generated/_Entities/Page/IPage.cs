// ReSharper disable All

namespace OpenTl.Schema
{
    using System;
	using System.Collections;

	using OpenTl.Schema;

    public interface IPage : IObject
    {
       TVector<IPageBlock> Blocks {get; set;}

       TVector<IPhoto> Photos {get; set;}

       TVector<IDocument> Documents {get; set;}

    }
}
