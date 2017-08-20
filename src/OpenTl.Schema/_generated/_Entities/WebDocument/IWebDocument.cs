// ReSharper disable All

namespace OpenTl.Schema
{
    using System;
	using System.Collections;

	using OpenTl.Schema;

    public interface IWebDocument : IObject
    {
       byte[] UrlAsBinary {get; set;}
       string Url {get; set;}

       long AccessHash {get; set;}

       int Size {get; set;}

       byte[] MimeTypeAsBinary {get; set;}
       string MimeType {get; set;}

       TVector<IDocumentAttribute> Attributes {get; set;}

       int DcId {get; set;}

    }
}
