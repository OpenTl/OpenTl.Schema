// ReSharper disable All

namespace OpenTl.Schema.Contacts
{
    using System;
	using System.Collections;

	using OpenTl.Schema;

    public interface ILink : IObject
    {
       OpenTl.Schema.IContactLink MyLink {get; set;}

       OpenTl.Schema.IContactLink ForeignLink {get; set;}

       OpenTl.Schema.IUser User {get; set;}

    }
}
