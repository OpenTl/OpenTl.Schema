// ReSharper disable All

namespace OpenTl.Schema
{
	using System;
	using System.Collections;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0xcad181f6)]
	public class TLangPackString : ILangPackString
	{
       [SerializationOrder(0)]
       public string Key {get; set;}

       [SerializationOrder(1)]
       public string Value {get; set;}

	}
}
