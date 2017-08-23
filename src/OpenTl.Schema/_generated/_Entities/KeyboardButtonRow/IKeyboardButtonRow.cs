// ReSharper disable All

namespace OpenTl.Schema
{
    using System;
	using System.Collections;

	using OpenTl.Schema;

    public interface IKeyboardButtonRow : IObject
    {
       OpenTl.Schema.TVector<OpenTl.Schema.IKeyboardButton> Buttons {get; set;}

    }
}
