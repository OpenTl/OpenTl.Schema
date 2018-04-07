// ReSharper disable All

namespace OpenTl.Schema
{
	using System;
	using System.Collections;
	using System.Text;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0x7761198)]
	public sealed class TUpdateChatParticipants : IUpdate
	{
       [SerializationOrder(0)]
       public OpenTl.Schema.IChatParticipants Participants {get; set;}

	}
}
