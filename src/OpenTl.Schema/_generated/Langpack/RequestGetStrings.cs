// ReSharper disable All

namespace OpenTl.Schema.Langpack
{
	using System;
	using System.Collections;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0x2e1ee318)]
    public class RequestGetStrings : IRequest<TVector<ILangPackString>>
    {
       [SerializationOrder(0)]
       public string LangCode {get; set;}

       [SerializationOrder(1)]
       public TVector<string> Keys {get; set;}

    }
}
