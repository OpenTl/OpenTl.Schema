// ReSharper disable All

namespace OpenTl.Schema
{
	using System;
	using System.Collections;
	using System.Text;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0xbec268ef)]
	public sealed class TUpdateNotifySettings : IUpdate
	{
       [SerializationOrder(0)]
       public OpenTl.Schema.INotifyPeer Peer {get; set;}

       [SerializationOrder(1)]
       public OpenTl.Schema.IPeerNotifySettings NotifySettings {get; set;}

	}
}
