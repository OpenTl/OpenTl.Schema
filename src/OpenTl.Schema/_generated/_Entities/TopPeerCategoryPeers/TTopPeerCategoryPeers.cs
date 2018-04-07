// ReSharper disable All

namespace OpenTl.Schema
{
	using System;
	using System.Collections;
	using System.Text;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0xfb834291)]
	public sealed class TTopPeerCategoryPeers : ITopPeerCategoryPeers
	{
       [SerializationOrder(0)]
       public OpenTl.Schema.ITopPeerCategory Category {get; set;}

       [SerializationOrder(1)]
       public int Count {get; set;}

       [SerializationOrder(2)]
       public OpenTl.Schema.TVector<OpenTl.Schema.ITopPeer> Peers {get; set;}

	}
}
