// ReSharper disable All

namespace OpenTl.Schema
{
    using System;
	using System.Collections;

	using OpenTl.Schema;

    public interface IMessageRange : IObject
    {
       int MinId {get; set;}

       int MaxId {get; set;}

    }
}
