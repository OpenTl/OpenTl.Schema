// ReSharper disable All

namespace OpenTl.Schema.Auth
{
	using System;
	using System.Collections;
	using System.Text;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0x3dbb5986)]
	public sealed class TSentCodeTypeApp : ISentCodeType
	{
       [SerializationOrder(0)]
       public int Length {get; set;}

	}
}
