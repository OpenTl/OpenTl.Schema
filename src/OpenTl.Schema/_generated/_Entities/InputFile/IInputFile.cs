// ReSharper disable All

namespace OpenTl.Schema
{
    using System;
	using System.Collections;

	using OpenTl.Schema;

    public interface IInputFile : IObject
    {
       long Id {get; set;}

       int Parts {get; set;}

       byte[] NameAsBinary {get; set;}
       string Name {get; set;}

    }
}
