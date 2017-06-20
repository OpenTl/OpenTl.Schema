namespace OpenTl.Schema
{
	using System;
	using System.Collections;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0x74ae4240)]
	public class TUpdates : IUpdates
	{
       [SerializationOrder(0)]
       public TVector<IUpdate> Updates {get; set;}

       [SerializationOrder(1)]
       public TVector<IUser> Users {get; set;}

       [SerializationOrder(2)]
       public TVector<IChat> Chats {get; set;}

       [SerializationOrder(3)]
       public int Date {get; set;}

       [SerializationOrder(4)]
       public int Seq {get; set;}

	}
}
