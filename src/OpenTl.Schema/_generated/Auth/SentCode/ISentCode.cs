// ReSharper disable All

namespace OpenTl.Schema.Auth
{
    using System;
	using System.Collections;

	using OpenTl.Schema;

    public interface ISentCode : IObject
    {
       BitArray Flags {get; set;}

       bool PhoneRegistered {get; set;}

       Auth.ISentCodeType Type {get; set;}

       byte[] PhoneCodeHashAsBinary {get; set;}
       string PhoneCodeHash {get; set;}

       Auth.ICodeType NextType {get; set;}

       int Timeout {get; set;}

    }
}
