// ReSharper disable All

namespace OpenTl.Schema
{
    using System;
	using System.Collections;

	using OpenTl.Schema;

    public interface IWallPaper : IObject
    {
       int Id {get; set;}

       byte[] TitleAsBinary {get; set;}
       string Title {get; set;}

       int Color {get; set;}

    }
}
