// ReSharper disable All

namespace OpenTl.Schema
{
    using System;
	using System.Collections;

	using OpenTl.Schema;

    public interface IFileLocation : IObject
    {
       long VolumeId {get; set;}

       int LocalId {get; set;}

       long Secret {get; set;}

    }
}
