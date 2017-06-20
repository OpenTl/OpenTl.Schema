namespace OpenTl.Schema.Messages
{
	using System;
	using System.Collections;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0x99262e37)]
	public class TChannelMessages : IMessages
	{
       [SerializationOrder(0)]
       public BitArray Flags {get; set;}

       [SerializationOrder(1)]
       public int Pts {get; set;}

       [SerializationOrder(2)]
       public int Count {get; set;}

       [SerializationOrder(3)]
       public TVector<IMessage> Messages {get; set;}

       [SerializationOrder(4)]
       public TVector<IChat> Chats {get; set;}

       [SerializationOrder(5)]
       public TVector<IUser> Users {get; set;}

	}
}
