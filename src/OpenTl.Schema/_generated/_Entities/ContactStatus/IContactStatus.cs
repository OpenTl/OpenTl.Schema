// ReSharper disable All

namespace OpenTl.Schema
{
    using System;
	using System.Collections;

	using OpenTl.Schema;

    public interface IContactStatus : IObject
    {
       int UserId {get; set;}

       OpenTl.Schema.IUserStatus Status {get; set;}

    }
}
