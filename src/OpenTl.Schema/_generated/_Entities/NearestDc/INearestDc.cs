// ReSharper disable All

namespace OpenTl.Schema
{
    using System;
	using System.Collections;

	using OpenTl.Schema;

    public interface INearestDc : IObject
    {
        string Country {get; set;}

        int ThisDc {get; set;}

        int NearestDc {get; set;}

    }
}
