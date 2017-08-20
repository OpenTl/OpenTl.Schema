// ReSharper disable All

namespace OpenTl.Schema
{
    using System;
	using System.Collections;

	using OpenTl.Schema;

    public interface IContact : IObject
    {
       int UserId {get; set;}

       bool Mutual {get; set;}

    }
}
