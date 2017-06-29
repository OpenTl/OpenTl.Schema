// ReSharper disable All

namespace OpenTl.Schema
{
    using System;
	using System.Collections;

	using OpenTl.Schema;

    public interface IInputWebFileLocation : IObject
    {
        string Url {get; set;}

        long AccessHash {get; set;}

    }
}
