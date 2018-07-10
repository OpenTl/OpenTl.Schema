// ReSharper disable All

namespace OpenTl.Schema
{
    using System;
	using System.Collections;

	using OpenTl.Schema;

    public interface ISecureData : IObject
    {
       byte[] Data {get; set;}

       byte[] DataHash {get; set;}

       byte[] Secret {get; set;}

    }
}
