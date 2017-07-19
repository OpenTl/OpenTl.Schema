// ReSharper disable All

namespace OpenTl.Schema.Langpack
{
	using System;
	using System.Collections;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0x9ab5c58e)]
    public class RequestGetLangPack : IRequest<ILangPackDifference>
    {
       [SerializationOrder(0)]
       public string LangCode {get; set;}

    }
}
