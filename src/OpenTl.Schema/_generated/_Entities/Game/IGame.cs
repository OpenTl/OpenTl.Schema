// ReSharper disable All

namespace OpenTl.Schema
{
    using System;
	using System.Collections;

	using OpenTl.Schema;

    public interface IGame : IObject
    {
       BitArray Flags {get; set;}

       long Id {get; set;}

       long AccessHash {get; set;}

       byte[] ShortNameAsBinary {get; set;}
       string ShortName {get; set;}

       byte[] TitleAsBinary {get; set;}
       string Title {get; set;}

       byte[] DescriptionAsBinary {get; set;}
       string Description {get; set;}

       OpenTl.Schema.IPhoto Photo {get; set;}

       OpenTl.Schema.IDocument Document {get; set;}

    }
}
