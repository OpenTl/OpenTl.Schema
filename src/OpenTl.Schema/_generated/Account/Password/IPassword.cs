// ReSharper disable All

namespace OpenTl.Schema.Account
{
    using System;
	using System.Collections;

	using OpenTl.Schema;

    public interface IPassword : IObject
    {
        byte[] NewSalt {get; set;}

        string EmailUnconfirmedPattern {get; set;}

    }
}
