// ReSharper disable All

namespace OpenTl.Schema
{
    using System;
	using System.Collections;

	using OpenTl.Schema;

    public interface IInputBotInlineMessage : IObject
    {
       BitArray Flags {get; set;}

       IReplyMarkup ReplyMarkup {get; set;}

    }
}
