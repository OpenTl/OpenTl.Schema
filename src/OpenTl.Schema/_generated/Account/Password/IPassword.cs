// ReSharper disable All

namespace OpenTl.Schema.Account
{
    using System;
	using System.Collections;

	using OpenTl.Schema;

    public interface IPassword : IObject
    {
       byte[] NewSalt {get; set;}

       byte[] NewSecureSalt {get; set;}

       byte[] SecureRandom {get; set;}

       byte[] EmailUnconfirmedPatternAsBinary {get; set;}
       string EmailUnconfirmedPattern {get; set;}

    }
}
