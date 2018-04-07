// ReSharper disable All

namespace OpenTl.Schema.Auth
{
	using System;
	using System.Collections;
	using System.Text;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0xc000bba2)]
	public sealed class TSentCodeTypeSms : ISentCodeType
	{
       [SerializationOrder(0)]
       public int Length {get; set;}

	}
}
