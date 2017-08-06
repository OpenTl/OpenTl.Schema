// ReSharper disable All

namespace OpenTl.Schema
{
    using System;
	using System.Collections;

	using OpenTl.Schema;

    public interface IDataJSON : IObject
    {
       byte[] DataAsBinary {get; set;}
       string Data {get; set;}

    }
}
