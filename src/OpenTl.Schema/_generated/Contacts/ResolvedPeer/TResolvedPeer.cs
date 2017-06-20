namespace OpenTl.Schema.Contacts
{
	using System;
	using System.Collections;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0x7f077ad9)]
	public class TResolvedPeer : IResolvedPeer
	{
       [SerializationOrder(0)]
       public IPeer Peer {get; set;}

       [SerializationOrder(1)]
       public TVector<IChat> Chats {get; set;}

       [SerializationOrder(2)]
       public TVector<IUser> Users {get; set;}

	}
}
