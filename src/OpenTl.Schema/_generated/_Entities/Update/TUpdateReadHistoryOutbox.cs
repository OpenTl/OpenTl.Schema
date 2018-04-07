// ReSharper disable All

namespace OpenTl.Schema
{
	using System;
	using System.Collections;
	using System.Text;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0x2f2f21bf)]
	public sealed class TUpdateReadHistoryOutbox : IUpdate
	{
       [SerializationOrder(0)]
       public OpenTl.Schema.IPeer Peer {get; set;}

       [SerializationOrder(1)]
       public int MaxId {get; set;}

       [SerializationOrder(2)]
       public int Pts {get; set;}

       [SerializationOrder(3)]
       public int PtsCount {get; set;}

	}
}
