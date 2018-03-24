// ReSharper disable All

namespace OpenTl.Schema
{
    using System;
	using System.Collections;

	using OpenTl.Schema;

    public interface IStickerSet : IObject
    {
       BitArray Flags {get; set;}

       bool Archived {get; set;}

       bool Official {get; set;}

       bool Masks {get; set;}

       int InstalledDate {get; set;}

       long Id {get; set;}

       long AccessHash {get; set;}

       byte[] TitleAsBinary {get; set;}
       string Title {get; set;}

       byte[] ShortNameAsBinary {get; set;}
       string ShortName {get; set;}

       int Count {get; set;}

       int Hash {get; set;}

    }
}
