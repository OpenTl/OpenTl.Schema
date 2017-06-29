// ReSharper disable All

namespace OpenTl.Schema
{
    using System;
	using System.Collections;

	using OpenTl.Schema;

    public interface ILabeledPrice : IObject
    {
        string Label {get; set;}

        long Amount {get; set;}

    }
}
