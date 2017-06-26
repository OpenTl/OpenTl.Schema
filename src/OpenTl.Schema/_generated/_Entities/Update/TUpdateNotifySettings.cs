// ReSharper disable All

namespace OpenTl.Schema
{
	using System;
	using System.Collections;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0xbec268ef)]
	public class TUpdateNotifySettings : IUpdate
	{
       [SerializationOrder(0)]
       public INotifyPeer Peer {get; set;}

       [SerializationOrder(1)]
       public IPeerNotifySettings NotifySettings {get; set;}

	}
}
