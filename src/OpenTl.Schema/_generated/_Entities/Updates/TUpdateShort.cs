// ReSharper disable All

namespace OpenTl.Schema
{
	using System;
	using System.Collections;
	using System.Text;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0x78d4dec1)]
	public sealed class TUpdateShort : IUpdates
	{
       [SerializationOrder(0)]
       public OpenTl.Schema.IUpdate Update {get; set;}

       [SerializationOrder(1)]
       public int Date {get; set;}

	}
}
