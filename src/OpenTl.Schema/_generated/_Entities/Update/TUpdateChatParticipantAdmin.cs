// ReSharper disable All

namespace OpenTl.Schema
{
	using System;
	using System.Collections;
	using System.Text;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0xb6901959)]
	public sealed class TUpdateChatParticipantAdmin : IUpdate
	{
       [SerializationOrder(0)]
       public int ChatId {get; set;}

       [SerializationOrder(1)]
       public int UserId {get; set;}

       [SerializationOrder(2)]
       public bool IsAdmin {get; set;}

       [SerializationOrder(3)]
       public int Version {get; set;}

	}
}
