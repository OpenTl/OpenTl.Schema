// ReSharper disable All

namespace OpenTl.Schema
{
    using System;
	using System.Collections;

	using OpenTl.Schema;

    public interface IBotCommand : IObject
    {
        string Command {get; set;}

        string Description {get; set;}

    }
}
