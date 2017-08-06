// ReSharper disable All

namespace OpenTl.Schema
{
    using System;
	using System.Collections;

	using OpenTl.Schema;

    public interface IMessageEntity : IObject
    {
       int Offset {get; set;}

       int Length {get; set;}

    }
}
