// ReSharper disable All

namespace OpenTl.Schema
{
	using System;
	using System.Collections;
	using System.Text;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0x7d861a08)]
	public sealed class TMsgResendReq : IObject
	{
       [SerializationOrder(0)]
       public OpenTl.Schema.TVector<long> MsgIds {get; set;}

	}
}
