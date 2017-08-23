// ReSharper disable All

namespace OpenTl.Schema
{
    using System;
	using System.Collections;

	using OpenTl.Schema;

    public interface IBotInlineResult : IObject
    {
       BitArray Flags {get; set;}

       byte[] IdAsBinary {get; set;}
       string Id {get; set;}

       byte[] TypeAsBinary {get; set;}
       string Type {get; set;}

       OpenTl.Schema.IBotInlineMessage SendMessage {get; set;}

    }
}
