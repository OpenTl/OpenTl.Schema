// ReSharper disable All

namespace OpenTl.Schema.Account
{
    using System;
	using System.Collections;

	using OpenTl.Schema;

    public interface IAuthorizations : IObject
    {
       OpenTl.Schema.TVector<OpenTl.Schema.IAuthorization> Authorizations {get; set;}

    }
}
