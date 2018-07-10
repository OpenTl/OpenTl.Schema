// ReSharper disable All

namespace OpenTl.Schema
{
    using System;
	using System.Collections;

	using OpenTl.Schema;

    public interface ISecureCredentialsEncrypted : IObject
    {
       byte[] Data {get; set;}

       byte[] Hash {get; set;}

       byte[] Secret {get; set;}

    }
}
