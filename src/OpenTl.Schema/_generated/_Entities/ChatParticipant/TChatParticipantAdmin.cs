// ReSharper disable All

namespace OpenTl.Schema
{
	using System;
	using System.Collections;
	using System.Text;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0xe2d6e436)]
	public sealed class TChatParticipantAdmin : IChatParticipant
	{
       [SerializationOrder(0)]
       public int UserId {get; set;}

       [SerializationOrder(1)]
       public int InviterId {get; set;}

       [SerializationOrder(2)]
       public int Date {get; set;}

	}
}
