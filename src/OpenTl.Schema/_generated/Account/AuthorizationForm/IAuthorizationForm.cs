// ReSharper disable All

namespace OpenTl.Schema.Account
{
    using System;
	using System.Collections;

	using OpenTl.Schema;

    public interface IAuthorizationForm : IObject
    {
       BitArray Flags {get; set;}

       OpenTl.Schema.TVector<OpenTl.Schema.ISecureRequiredType> RequiredTypes {get; set;}

       OpenTl.Schema.TVector<OpenTl.Schema.ISecureValue> Values {get; set;}

       OpenTl.Schema.TVector<OpenTl.Schema.ISecureValueError> Errors {get; set;}

       OpenTl.Schema.TVector<OpenTl.Schema.IUser> Users {get; set;}

       byte[] PrivacyPolicyUrlAsBinary {get; set;}
       string PrivacyPolicyUrl {get; set;}

    }
}
