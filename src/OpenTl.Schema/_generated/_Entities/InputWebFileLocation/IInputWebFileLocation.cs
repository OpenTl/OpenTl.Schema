// ReSharper disable All

namespace OpenTl.Schema
{
    using System;
	using System.Collections;

	using OpenTl.Schema;

    public interface IInputWebFileLocation : IObject
    {
       byte[] UrlAsBinary {get; set;}
       string Url {get; set;}

       long AccessHash {get; set;}

    }
}
