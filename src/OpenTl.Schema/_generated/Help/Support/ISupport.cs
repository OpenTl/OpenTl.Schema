// ReSharper disable All

namespace OpenTl.Schema.Help
{
    using System;
	using System.Collections;

	using OpenTl.Schema;

    public interface ISupport : IObject
    {
        string PhoneNumber {get; set;}

        IUser User {get; set;}

    }
}
