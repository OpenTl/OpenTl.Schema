// ReSharper disable All

namespace OpenTl.Schema
{
    using System;
	using System.Collections;

	using OpenTl.Schema;

    public interface IImportedContact : IObject
    {
       int UserId {get; set;}

       long ClientId {get; set;}

    }
}
