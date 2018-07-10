// ReSharper disable All

namespace OpenTl.Schema
{
	using System;
	using System.Collections;
	using System.Text;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0xd433ad73)]
	public sealed class TIpPort : IIpPort
	{
       [SerializationOrder(0)]
       public int Ipv4 {get; set;}

       [SerializationOrder(1)]
       public int Port {get; set;}

	}
}
