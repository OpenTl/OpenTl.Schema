// ReSharper disable All

namespace OpenTl.Schema
{
    using System;
	using System.Collections;

	using OpenTl.Schema;

    public interface IDisabledFeature : IObject
    {
       byte[] FeatureAsBinary {get; set;}
       string Feature {get; set;}

       byte[] DescriptionAsBinary {get; set;}
       string Description {get; set;}

    }
}
