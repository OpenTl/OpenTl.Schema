// ReSharper disable All

namespace OpenTl.Schema
{
    using System;
	using System.Collections;

	using OpenTl.Schema;

    public interface IInputDialogPeer : IObject
    {
       OpenTl.Schema.IInputPeer Peer {get; set;}

    }
}
