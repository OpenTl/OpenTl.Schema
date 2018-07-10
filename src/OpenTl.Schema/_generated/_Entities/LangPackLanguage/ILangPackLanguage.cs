// ReSharper disable All

namespace OpenTl.Schema
{
    using System;
	using System.Collections;

	using OpenTl.Schema;

    public interface ILangPackLanguage : IObject
    {
       byte[] NameAsBinary {get; set;}
       string Name {get; set;}

       byte[] NativeNameAsBinary {get; set;}
       string NativeName {get; set;}

       byte[] LangCodeAsBinary {get; set;}
       string LangCode {get; set;}

    }
}
