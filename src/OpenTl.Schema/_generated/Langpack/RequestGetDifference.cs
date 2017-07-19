// ReSharper disable All

namespace OpenTl.Schema.Langpack
{
	using System;
	using System.Collections;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0xb2e4d7d)]
    public class RequestGetDifference : IRequest<ILangPackDifference>
    {
       [SerializationOrder(0)]
       public int FromVersion {get; set;}

    }
}
