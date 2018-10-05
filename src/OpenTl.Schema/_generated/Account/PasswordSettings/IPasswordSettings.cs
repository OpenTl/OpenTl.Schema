// ReSharper disable All

namespace OpenTl.Schema.Account
{
    using System;
	using System.Collections;

	using OpenTl.Schema;

    public interface IPasswordSettings : IObject
    {
       BitArray Flags {get; set;}

       byte[] EmailAsBinary {get; set;}
       string Email {get; set;}

       OpenTl.Schema.ISecureSecretSettings SecureSettings {get; set;}

    }
}
