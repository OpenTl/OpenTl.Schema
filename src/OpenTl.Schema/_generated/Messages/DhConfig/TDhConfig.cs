// ReSharper disable All

namespace OpenTl.Schema.Messages
{
	using System;
	using System.Collections;
	using System.Text;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0x2c221edd)]
	public sealed class TDhConfig : IDhConfig
	{
       [SerializationOrder(0)]
       public int G {get; set;}

       [SerializationOrder(1)]
       public byte[] P {get; set;}

       [SerializationOrder(2)]
       public int Version {get; set;}

       [SerializationOrder(3)]
       public byte[] Random {get; set;}

	}
}
