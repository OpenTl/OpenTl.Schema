// ReSharper disable All

namespace OpenTl.Schema
{
    using System;
	using System.Collections;

	using OpenTl.Schema;

    public interface IInputEncryptedChat : IObject
    {
       int ChatId {get; set;}

       long AccessHash {get; set;}

    }
}
