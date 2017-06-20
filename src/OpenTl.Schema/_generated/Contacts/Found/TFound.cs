namespace OpenTl.Schema.Contacts
{
	using System;
	using System.Collections;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0x1aa1f784)]
	public class TFound : IFound
	{
       [SerializationOrder(0)]
       public TVector<IPeer> Results {get; set;}

       [SerializationOrder(1)]
       public TVector<IChat> Chats {get; set;}

       [SerializationOrder(2)]
       public TVector<IUser> Users {get; set;}

	}
}
