// ReSharper disable All

namespace OpenTl.Schema
{
	using System;
	using System.Collections;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0xda13538a)]
	public class TChatParticipantCreator : IChatParticipant
	{
       [SerializationOrder(0)]
       public int UserId {get; set;}

	}
}
