// ReSharper disable All

namespace OpenTl.Schema.Messages
{
	using System;
	using System.Collections;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0x8c718e87)]
	public class TMessages : IMessages
	{
       [SerializationOrder(0)]
       public TVector<IMessage> Messages {get; set;}

       [SerializationOrder(1)]
       public TVector<IChat> Chats {get; set;}

       [SerializationOrder(2)]
       public TVector<IUser> Users {get; set;}

	}
}
