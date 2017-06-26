// ReSharper disable All

namespace OpenTl.Schema.Messages
{
	using System;
	using System.Collections;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0xc0e24635)]
	public class TDhConfigNotModified : IDhConfig
	{
       [SerializationArrayLength(-1)]
       [SerializationOrder(0)]
       public byte[] Random {get; set;}

	}
}
