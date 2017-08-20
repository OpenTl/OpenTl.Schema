// ReSharper disable All

namespace OpenTl.Schema.Messages
{
    using System;
	using System.Collections;

	using OpenTl.Schema;

    public interface IAffectedMessages : IObject
    {
       int Pts {get; set;}

       int PtsCount {get; set;}

    }
}
