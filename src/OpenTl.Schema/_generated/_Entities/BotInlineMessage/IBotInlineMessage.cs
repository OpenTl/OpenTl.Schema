// ReSharper disable All

namespace OpenTl.Schema
{
    using System;
	using System.Collections;

	using OpenTl.Schema;

    public interface IBotInlineMessage : IObject
    {
       BitArray Flags {get; set;}

       OpenTl.Schema.IReplyMarkup ReplyMarkup {get; set;}

    }
}
