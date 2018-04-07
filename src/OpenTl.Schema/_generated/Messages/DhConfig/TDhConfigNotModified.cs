// ReSharper disable All

namespace OpenTl.Schema.Messages
{
	using System;
	using System.Collections;
	using System.Text;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0xc0e24635)]
	public sealed class TDhConfigNotModified : IDhConfig
	{
       [SerializationOrder(0)]
       public byte[] Random {get; set;}

	}
}
