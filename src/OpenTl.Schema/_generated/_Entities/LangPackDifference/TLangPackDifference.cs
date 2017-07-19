// ReSharper disable All

namespace OpenTl.Schema
{
	using System;
	using System.Collections;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0xf385c1f6)]
	public class TLangPackDifference : ILangPackDifference
	{
       [SerializationOrder(0)]
       public string LangCode {get; set;}

       [SerializationOrder(1)]
       public int FromVersion {get; set;}

       [SerializationOrder(2)]
       public int Version {get; set;}

       [SerializationOrder(3)]
       public TVector<ILangPackString> Strings {get; set;}

	}
}
