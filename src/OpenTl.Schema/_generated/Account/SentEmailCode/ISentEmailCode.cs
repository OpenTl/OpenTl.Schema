// ReSharper disable All

namespace OpenTl.Schema.Account
{
    using System;
	using System.Collections;

	using OpenTl.Schema;

    public interface ISentEmailCode : IObject
    {
       byte[] EmailPatternAsBinary {get; set;}
       string EmailPattern {get; set;}

       int Length {get; set;}

    }
}
