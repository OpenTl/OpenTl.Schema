// ReSharper disable All

namespace OpenTl.Schema
{
    using System;
	using System.Collections;

	using OpenTl.Schema;

    public interface IExportedMessageLink : IObject
    {
       byte[] LinkAsBinary {get; set;}
       string Link {get; set;}

       byte[] HtmlAsBinary {get; set;}
       string Html {get; set;}

    }
}
