// ReSharper disable All

namespace OpenTl.Schema
{
	using System;
	using System.Collections;
	using System.Text;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0xc8d7493e)]
	public sealed class TChatParticipant : IChatParticipant
	{
       [SerializationOrder(0)]
       public int UserId {get; set;}

       [SerializationOrder(1)]
       public int InviterId {get; set;}

       [SerializationOrder(2)]
       public int Date {get; set;}

	}
}
