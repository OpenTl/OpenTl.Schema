// ReSharper disable All

namespace OpenTl.Schema
{
    using System;
	using System.Collections;

	using OpenTl.Schema;

    public interface IInputWebDocument : IObject
    {
        string Url {get; set;}

        int Size {get; set;}

        string MimeType {get; set;}

        TVector<IDocumentAttribute> Attributes {get; set;}

    }
}
