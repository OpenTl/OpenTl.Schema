// ReSharper disable All

namespace OpenTl.Schema
{
    using System;
	using System.Collections;

	using OpenTl.Schema;

    public interface IEncryptedMessage : IObject
    {
       long RandomId {get; set;}

       int ChatId {get; set;}

       int Date {get; set;}

       byte[] Bytes {get; set;}

    }
}
