// ReSharper disable All

namespace OpenTl.Schema.Auth
{
    using System;
	using System.Collections;

	using OpenTl.Schema;

    public interface IPasswordRecovery : IObject
    {
        string EmailPattern {get; set;}

    }
}
