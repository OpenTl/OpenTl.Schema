// ReSharper disable All

namespace OpenTl.Schema
{
    using System;
	using System.Collections;

	using OpenTl.Schema;

    public interface ILangPackString : IObject
    {
       byte[] KeyAsBinary {get; set;}
       string Key {get; set;}

    }
}
