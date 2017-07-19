// ReSharper disable All

namespace OpenTl.Schema
{
	using System;
	using System.Collections;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0x56022f4d)]
	public class TUpdateLangPack : IUpdate
	{
       [SerializationOrder(0)]
       public ILangPackDifference Difference {get; set;}

	}
}
