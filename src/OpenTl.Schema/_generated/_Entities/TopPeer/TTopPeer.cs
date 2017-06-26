// ReSharper disable All

namespace OpenTl.Schema
{
	using System;
	using System.Collections;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0xedcdc05b)]
	public class TTopPeer : ITopPeer
	{
       [SerializationOrder(0)]
       public IPeer Peer {get; set;}

       [SerializationOrder(1)]
       public double Rating {get; set;}

	}
}
