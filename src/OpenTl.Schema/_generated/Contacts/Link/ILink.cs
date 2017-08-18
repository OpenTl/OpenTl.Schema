// ReSharper disable All

namespace OpenTl.Schema.Contacts
{
    using System;
	using System.Collections;

	using OpenTl.Schema;

    public interface ILink : IObject
    {
       IContactLink MyLink {get; set;}

       IContactLink ForeignLink {get; set;}

       IUser User {get; set;}

    }
}
