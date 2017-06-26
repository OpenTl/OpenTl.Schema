// ReSharper disable All

namespace OpenTl.Schema
{
	using System;
	using System.Collections;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0x62d6b459)]
	public class TMsgsAck : IObject
	{
       [SerializationOrder(0)]
       public TVector<long> MsgIds {get; set;}

	}
}
