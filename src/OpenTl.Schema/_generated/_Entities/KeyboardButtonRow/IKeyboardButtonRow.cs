// ReSharper disable All

namespace OpenTl.Schema
{
    using System;
	using System.Collections;

	using OpenTl.Schema;

    public interface IKeyboardButtonRow : IObject
    {
       TVector<IKeyboardButton> Buttons {get; set;}

    }
}
