// ReSharper disable All

namespace OpenTl.Schema.Auth
{
	using System;
	using System.Collections;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0x3dbb5986)]
	public class TSentCodeTypeApp : ISentCodeType
	{
       [SerializationOrder(0)]
       public int Length {get; set;}

	}
}
