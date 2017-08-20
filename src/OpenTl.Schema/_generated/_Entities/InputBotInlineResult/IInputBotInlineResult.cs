// ReSharper disable All

namespace OpenTl.Schema
{
    using System;
	using System.Collections;

	using OpenTl.Schema;

    public interface IInputBotInlineResult : IObject
    {
       byte[] IdAsBinary {get; set;}
       string Id {get; set;}

       IInputBotInlineMessage SendMessage {get; set;}

    }
}
