// ReSharper disable All

namespace OpenTl.Schema
{
    using System;
	using System.Collections;

	using OpenTl.Schema;

    public interface IStickerSet : IObject
    {
        BitArray Flags {get; set;}

        bool Installed {get; set;}

        bool Archived {get; set;}

        bool Official {get; set;}

        bool Masks {get; set;}

        long Id {get; set;}

        long AccessHash {get; set;}

        string Title {get; set;}

        string ShortName {get; set;}

        int Count {get; set;}

        int Hash {get; set;}

    }
}
