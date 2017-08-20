// ReSharper disable All

namespace OpenTl.Schema
{
    using System;
	using System.Collections;

	using OpenTl.Schema;

    public interface IKeyboardButton : IObject
    {
       byte[] TextAsBinary {get; set;}
       string Text {get; set;}

    }
}
