// ReSharper disable All

namespace OpenTl.Schema
{
    using System;
	using System.Collections;

	using OpenTl.Schema;

    public interface ITopPeerCategoryPeers : IObject
    {
       ITopPeerCategory Category {get; set;}

       int Count {get; set;}

       TVector<ITopPeer> Peers {get; set;}

    }
}
