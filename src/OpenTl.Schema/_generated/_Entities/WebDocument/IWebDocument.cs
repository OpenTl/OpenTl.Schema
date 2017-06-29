// ReSharper disable All

namespace OpenTl.Schema
{
    using System;
	using System.Collections;

	using OpenTl.Schema;

    public interface IWebDocument : IObject
    {
        string Url {get; set;}

        long AccessHash {get; set;}

        int Size {get; set;}

        string MimeType {get; set;}

        TVector<IDocumentAttribute> Attributes {get; set;}

        int DcId {get; set;}

    }
}
