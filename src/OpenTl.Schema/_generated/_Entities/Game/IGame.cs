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

        string ShortName {get; set;}

        string Title {get; set;}

        string Description {get; set;}

        IPhoto Photo {get; set;}

        IDocument Document {get; set;}

    }
}
