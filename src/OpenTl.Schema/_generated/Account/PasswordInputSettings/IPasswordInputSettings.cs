// ReSharper disable All

namespace OpenTl.Schema.Account
{
    using System;
	using System.Collections;

	using OpenTl.Schema;

    public interface IPasswordInputSettings : IObject
    {
       BitArray Flags {get; set;}

       OpenTl.Schema.IPasswordKdfAlgo NewAlgo {get; set;}

       byte[] NewPasswordHash {get; set;}

       byte[] HintAsBinary {get; set;}
       string Hint {get; set;}

       byte[] EmailAsBinary {get; set;}
       string Email {get; set;}

       OpenTl.Schema.ISecureSecretSettings NewSecureSettings {get; set;}

    }
}
