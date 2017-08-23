// ReSharper disable All

namespace OpenTl.Schema
{
    using System;
	using System.Collections;

	using OpenTl.Schema;

    public interface ITopPeerCategoryPeers : IObject
    {
       OpenTl.Schema.ITopPeerCategory Category {get; set;}

       int Count {get; set;}

       OpenTl.Schema.TVector<OpenTl.Schema.ITopPeer> Peers {get; set;}

    }
}
