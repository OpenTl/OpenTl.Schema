// ReSharper disable All

namespace OpenTl.Schema
{
	using System;
	using System.Collections;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0xda69fb52)]
	public class TMsgsStateReq : IObject
	{
       [SerializationOrder(0)]
       public TVector<long> MsgIds {get; set;}

	}
}
