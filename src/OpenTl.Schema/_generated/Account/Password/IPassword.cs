// ReSharper disable All

namespace OpenTl.Schema.Account
{
    using System;
	using System.Collections;

	using OpenTl.Schema;

    public interface IPassword : IObject
    {
       BitArray Flags {get; set;}

       bool HasRecovery {get; set;}

       bool HasSecureValues {get; set;}

       bool HasPassword {get; set;}

       OpenTl.Schema.IPasswordKdfAlgo CurrentAlgo {get; set;}

       byte[] SrpB {get; set;}

       long SrpId {get; set;}

       byte[] HintAsBinary {get; set;}
       string Hint {get; set;}

       byte[] EmailUnconfirmedPatternAsBinary {get; set;}
       string EmailUnconfirmedPattern {get; set;}

       OpenTl.Schema.IPasswordKdfAlgo NewAlgo {get; set;}

       OpenTl.Schema.ISecurePasswordKdfAlgo NewSecureAlgo {get; set;}

       byte[] SecureRandom {get; set;}

    }
}
