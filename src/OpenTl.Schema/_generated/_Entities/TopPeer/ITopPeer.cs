// ReSharper disable All

namespace OpenTl.Schema
{
    using System;
	using System.Collections;

	using OpenTl.Schema;

    public interface ITopPeer : IObject
    {
       IPeer Peer {get; set;}

       double Rating {get; set;}

    }
}
