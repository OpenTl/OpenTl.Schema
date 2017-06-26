// ReSharper disable All

namespace OpenTl.Schema.Messages
{
	using System;
	using System.Collections;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0x64ff9fd5)]
	public class TChats : IChats
	{
       [SerializationOrder(0)]
       public TVector<IChat> Chats {get; set;}

	}
}
