// ReSharper disable All

namespace OpenTl.Schema.Account
{
    using System;
	using System.Collections;

	using OpenTl.Schema;

    public interface IPrivacyRules : IObject
    {
       TVector<IPrivacyRule> Rules {get; set;}

       TVector<IUser> Users {get; set;}

    }
}
