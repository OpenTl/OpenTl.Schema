// ReSharper disable All

namespace OpenTl.Schema
{
    using System;
	using System.Collections;

	using OpenTl.Schema;

    public interface IPage : IObject
    {
       OpenTl.Schema.TVector<OpenTl.Schema.IPageBlock> Blocks {get; set;}

       OpenTl.Schema.TVector<OpenTl.Schema.IPhoto> Photos {get; set;}

       OpenTl.Schema.TVector<OpenTl.Schema.IDocument> Documents {get; set;}

    }
}
