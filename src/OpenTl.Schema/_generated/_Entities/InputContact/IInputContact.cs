// ReSharper disable All

namespace OpenTl.Schema
{
    using System;
	using System.Collections;

	using OpenTl.Schema;

    public interface IInputContact : IObject
    {
        long ClientId {get; set;}

        string Phone {get; set;}

        string FirstName {get; set;}

        string LastName {get; set;}

    }
}
