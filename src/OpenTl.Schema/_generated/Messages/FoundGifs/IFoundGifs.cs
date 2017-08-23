// ReSharper disable All

namespace OpenTl.Schema.Messages
{
    using System;
	using System.Collections;

	using OpenTl.Schema;

    public interface IFoundGifs : IObject
    {
       int NextOffset {get; set;}

       OpenTl.Schema.TVector<OpenTl.Schema.IFoundGif> Results {get; set;}

    }
}
