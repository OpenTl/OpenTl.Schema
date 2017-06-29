// ReSharper disable All

namespace OpenTl.Schema.Account
{
    using System;
	using System.Collections;

	using OpenTl.Schema;

    public interface IPasswordSettings : IObject
    {
        string Email {get; set;}

    }
}
