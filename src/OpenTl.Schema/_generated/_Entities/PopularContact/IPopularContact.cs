// ReSharper disable All

namespace OpenTl.Schema
{
    using System;
	using System.Collections;

	using OpenTl.Schema;

    public interface IPopularContact : IObject
    {
       long ClientId {get; set;}

       int Importers {get; set;}

    }
}
