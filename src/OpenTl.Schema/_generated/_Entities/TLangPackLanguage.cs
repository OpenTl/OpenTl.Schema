// ReSharper disable All

namespace OpenTl.Schema
{
	using System;
	using System.Collections;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0x117698f1)]
	public class TLangPackLanguage : IObject
	{
       [SerializationOrder(0)]
       public string Name {get; set;}

       [SerializationOrder(1)]
       public string NativeName {get; set;}

       [SerializationOrder(2)]
       public string LangCode {get; set;}

	}
}
