// ReSharper disable All

namespace OpenTl.Schema.Auth
{
	using System;
	using System.Collections;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0xab03c6d9)]
	public class TSentCodeTypeFlashCall : ISentCodeType
	{
       [SerializationOrder(0)]
       public string Pattern {get; set;}

	}
}
