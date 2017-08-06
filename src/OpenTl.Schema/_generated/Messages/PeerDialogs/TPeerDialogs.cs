// ReSharper disable All

namespace OpenTl.Schema.Messages
{
	using System;
	using System.Collections;
	using System.Text;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0x3371c354)]
	public class TPeerDialogs : IPeerDialogs
	{
       [SerializationOrder(0)]
       public TVector<IDialog> Dialogs {get; set;}

       [SerializationOrder(1)]
       public TVector<IMessage> Messages {get; set;}

       [SerializationOrder(2)]
       public TVector<IChat> Chats {get; set;}

       [SerializationOrder(3)]
       public TVector<IUser> Users {get; set;}

       [SerializationOrder(4)]
       public Updates.IState State {get; set;}

	}
}
