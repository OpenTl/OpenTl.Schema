// ReSharper disable All

namespace OpenTl.Schema
{
    using System;
	using System.Collections;

	using OpenTl.Schema;

    public interface ISavedContact : IObject
    {
       byte[] PhoneAsBinary {get; set;}
       string Phone {get; set;}

       byte[] FirstNameAsBinary {get; set;}
       string FirstName {get; set;}

       byte[] LastNameAsBinary {get; set;}
       string LastName {get; set;}

       int Date {get; set;}

    }
}
