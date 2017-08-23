// ReSharper disable All

namespace OpenTl.Schema.Auth
{
    using System;
	using System.Collections;

	using OpenTl.Schema;

    public interface IAuthorization : IObject
    {
       BitArray Flags {get; set;}

       int TmpSessions {get; set;}

       OpenTl.Schema.IUser User {get; set;}

    }
}
