// ReSharper disable All

namespace OpenTl.Schema
{
    using System;
	using System.Collections;

	using OpenTl.Schema;

    public interface IBotCommand : IObject
    {
       byte[] CommandAsBinary {get; set;}
       string Command {get; set;}

       byte[] DescriptionAsBinary {get; set;}
       string Description {get; set;}

    }
}
