// ReSharper disable All

namespace OpenTl.Schema
{
    using System;
	using System.Collections;

	using OpenTl.Schema;

    public interface ISecureSecretSettings : IObject
    {
       OpenTl.Schema.ISecurePasswordKdfAlgo SecureAlgo {get; set;}

       byte[] SecureSecret {get; set;}

       long SecureSecretId {get; set;}

    }
}
