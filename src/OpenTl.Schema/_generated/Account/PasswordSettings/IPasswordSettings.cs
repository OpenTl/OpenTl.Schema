// ReSharper disable All

namespace OpenTl.Schema.Account
{
    using System;
	using System.Collections;

	using OpenTl.Schema;

    public interface IPasswordSettings : IObject
    {
       byte[] EmailAsBinary {get; set;}
       string Email {get; set;}

       byte[] SecureSalt {get; set;}

       byte[] SecureSecret {get; set;}

       long SecureSecretId {get; set;}

    }
}
