// ReSharper disable All

namespace OpenTl.Schema.Help
{
    using System;
	using System.Collections;

	using OpenTl.Schema;

    public interface ISupport : IObject
    {
       byte[] PhoneNumberAsBinary {get; set;}
       string PhoneNumber {get; set;}

       OpenTl.Schema.IUser User {get; set;}

    }
}
