// ReSharper disable All

namespace OpenTl.Schema
{
    using System;
	using System.Collections;

	using OpenTl.Schema;

    public interface ILangPackDifference : IObject
    {
       byte[] LangCodeAsBinary {get; set;}
       string LangCode {get; set;}

       int FromVersion {get; set;}

       int Version {get; set;}

       OpenTl.Schema.TVector<OpenTl.Schema.ILangPackString> Strings {get; set;}

    }
}
