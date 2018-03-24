// ReSharper disable All

namespace OpenTl.Schema
{
    using System;
	using System.Collections;

	using OpenTl.Schema;

    public interface IDialogPeer : IObject
    {
       OpenTl.Schema.IPeer Peer {get; set;}

    }
}
