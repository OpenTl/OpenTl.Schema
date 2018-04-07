// ReSharper disable All

namespace OpenTl.Schema
{
	using System;
	using System.Collections;
	using System.Text;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0xda69fb52)]
	public sealed class TMsgsStateReq : IObject
	{
       [SerializationOrder(0)]
       public OpenTl.Schema.TVector<long> MsgIds {get; set;}

	}
}
