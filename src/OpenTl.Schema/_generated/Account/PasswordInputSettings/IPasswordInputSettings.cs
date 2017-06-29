// ReSharper disable All

namespace OpenTl.Schema.Account
{
    using System;
	using System.Collections;

	using OpenTl.Schema;

    public interface IPasswordInputSettings : IObject
    {
        BitArray Flags {get; set;}

        byte[] NewSalt {get; set;}

        byte[] NewPasswordHash {get; set;}

        string Hint {get; set;}

        string Email {get; set;}

    }
}
