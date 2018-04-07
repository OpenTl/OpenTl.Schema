// ReSharper disable All

namespace OpenTl.Schema.Langpack
{
	using System;
	using System.Collections;
	using System.Text;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0xb2e4d7d)]
    public sealed class RequestGetDifference : IRequest<OpenTl.Schema.ILangPackDifference>
    {
       [SerializationOrder(0)]
       public int FromVersion {get; set;}

    }
}
