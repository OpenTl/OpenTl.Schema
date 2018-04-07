// ReSharper disable All

namespace OpenTl.Schema
{
	using System;
	using System.Collections;
	using System.Text;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0x56022f4d)]
	public sealed class TUpdateLangPack : IUpdate
	{
       [SerializationOrder(0)]
       public OpenTl.Schema.ILangPackDifference Difference {get; set;}

	}
}
