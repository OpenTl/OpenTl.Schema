// ReSharper disable All

namespace OpenTl.Schema
{
    using System;
	using System.Collections;

	using OpenTl.Schema;

    public interface IInputClientProxy : IObject
    {
       byte[] AddressAsBinary {get; set;}
       string Address {get; set;}

       int Port {get; set;}

    }
}
