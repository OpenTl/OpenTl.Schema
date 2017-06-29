// ReSharper disable All

namespace OpenTl.Schema
{
    using System;
	using System.Collections;

	using OpenTl.Schema;

    public interface IPaymentSavedCredentials : IObject
    {
        string Id {get; set;}

        string Title {get; set;}

    }
}
