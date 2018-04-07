// ReSharper disable All

namespace OpenTl.Schema.Auth
{
	using System;
	using System.Collections;
	using System.Text;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0x5353e5a7)]
	public sealed class TSentCodeTypeCall : ISentCodeType
	{
       [SerializationOrder(0)]
       public int Length {get; set;}

	}
}
