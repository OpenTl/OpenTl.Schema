// ReSharper disable All

namespace OpenTl.Schema.Messages
{
	using System;
	using System.Collections;
	using System.Text;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0xb446ae3)]
	public class TMessagesSlice : IMessages
	{
       [SerializationOrder(0)]
       public int Count {get; set;}

       [SerializationOrder(1)]
       public TVector<IMessage> Messages {get; set;}

       [SerializationOrder(2)]
       public TVector<IChat> Chats {get; set;}

       [SerializationOrder(3)]
       public TVector<IUser> Users {get; set;}

	}
}
