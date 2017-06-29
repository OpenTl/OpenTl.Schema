// ReSharper disable All

namespace OpenTl.Schema
{
    using System;
	using System.Collections;

	using OpenTl.Schema;

    public interface IDisabledFeature : IObject
    {
        string Feature {get; set;}

        string Description {get; set;}

    }
}
