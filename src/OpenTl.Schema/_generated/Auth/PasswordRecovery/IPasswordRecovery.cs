// ReSharper disable All

namespace OpenTl.Schema.Auth
{
    using System;
	using System.Collections;

	using OpenTl.Schema;

    public interface IPasswordRecovery : IObject
    {
       byte[] EmailPatternAsBinary {get; set;}
       string EmailPattern {get; set;}

    }
}
