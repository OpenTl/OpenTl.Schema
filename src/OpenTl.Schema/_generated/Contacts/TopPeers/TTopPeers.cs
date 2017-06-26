// ReSharper disable All

namespace OpenTl.Schema.Contacts
{
	using System;
	using System.Collections;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0x70b772a8)]
	public class TTopPeers : ITopPeers
	{
       [SerializationOrder(0)]
       public TVector<ITopPeerCategoryPeers> Categories {get; set;}

       [SerializationOrder(1)]
       public TVector<IChat> Chats {get; set;}

       [SerializationOrder(2)]
       public TVector<IUser> Users {get; set;}

	}
}
