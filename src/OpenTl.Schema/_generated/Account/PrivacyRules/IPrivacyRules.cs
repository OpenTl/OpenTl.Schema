// ReSharper disable All

namespace OpenTl.Schema.Account
{
    using System;
	using System.Collections;

	using OpenTl.Schema;

    public interface IPrivacyRules : IObject
    {
       OpenTl.Schema.TVector<OpenTl.Schema.IPrivacyRule> Rules {get; set;}

       OpenTl.Schema.TVector<OpenTl.Schema.IUser> Users {get; set;}

    }
}
