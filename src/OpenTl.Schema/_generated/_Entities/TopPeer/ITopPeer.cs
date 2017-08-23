// ReSharper disable All

namespace OpenTl.Schema
{
    using System;
	using System.Collections;

	using OpenTl.Schema;

    public interface ITopPeer : IObject
    {
       OpenTl.Schema.IPeer Peer {get; set;}

       double Rating {get; set;}

    }
}
