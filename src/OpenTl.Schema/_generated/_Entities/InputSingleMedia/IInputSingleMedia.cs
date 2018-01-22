// ReSharper disable All

namespace OpenTl.Schema
{
    using System;
	using System.Collections;

	using OpenTl.Schema;

    public interface IInputSingleMedia : IObject
    {
       OpenTl.Schema.IInputMedia Media {get; set;}

       long RandomId {get; set;}

    }
}
