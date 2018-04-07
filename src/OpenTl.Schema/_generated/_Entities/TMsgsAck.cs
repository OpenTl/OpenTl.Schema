// ReSharper disable All

namespace OpenTl.Schema
{
	using System;
	using System.Collections;
	using System.Text;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0x62d6b459)]
	public sealed class TMsgsAck : IObject
	{
       [SerializationOrder(0)]
       public OpenTl.Schema.TVector<long> MsgIds {get; set;}

	}
}
