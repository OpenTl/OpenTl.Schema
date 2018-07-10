// ReSharper disable All

namespace OpenTl.Schema.Help
{
	using System;
	using System.Collections;
	using System.Text;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0x2bf7ee23)]
	public sealed class TProxyDataPromo : IProxyData
	{
       [SerializationOrder(0)]
       public int Expires {get; set;}

       [SerializationOrder(1)]
       public OpenTl.Schema.IPeer Peer {get; set;}

       [SerializationOrder(2)]
       public OpenTl.Schema.TVector<OpenTl.Schema.IChat> Chats {get; set;}

       [SerializationOrder(3)]
       public OpenTl.Schema.TVector<OpenTl.Schema.IUser> Users {get; set;}

	}
}
