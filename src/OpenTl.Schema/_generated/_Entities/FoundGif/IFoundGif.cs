// ReSharper disable All

namespace OpenTl.Schema
{
    using System;
	using System.Collections;

	using OpenTl.Schema;

    public interface IFoundGif : IObject
    {
       byte[] UrlAsBinary {get; set;}
       string Url {get; set;}

    }
}
