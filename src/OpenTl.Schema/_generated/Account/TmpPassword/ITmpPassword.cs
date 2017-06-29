// ReSharper disable All

namespace OpenTl.Schema.Account
{
    using System;
	using System.Collections;

	using OpenTl.Schema;

    public interface ITmpPassword : IObject
    {
        byte[] MpPassword {get; set;}

        int ValidUntil {get; set;}

    }
}
