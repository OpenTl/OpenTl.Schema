// ReSharper disable All

namespace OpenTl.Schema
{
    using System;
	using System.Collections;

	using OpenTl.Schema;

    public interface IBotInlineResult : IObject
    {
        BitArray Flags {get; set;}

        string Id {get; set;}

        string Type {get; set;}

        IBotInlineMessage SendMessage {get; set;}

    }
}
