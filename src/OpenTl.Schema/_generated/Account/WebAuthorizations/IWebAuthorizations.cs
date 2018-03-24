// ReSharper disable All

namespace OpenTl.Schema.Account
{
    using System;
	using System.Collections;

	using OpenTl.Schema;

    public interface IWebAuthorizations : IObject
    {
       OpenTl.Schema.TVector<OpenTl.Schema.IWebAuthorization> Authorizations {get; set;}

       OpenTl.Schema.TVector<OpenTl.Schema.IUser> Users {get; set;}

    }
}
