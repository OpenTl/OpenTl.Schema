// ReSharper disable All

namespace OpenTl.Schema
{
	using System;
	using System.Collections;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0xfc2e05bc)]
	public class TChatInviteExported : IExportedChatInvite
	{
       [SerializationOrder(0)]
       public string Link {get; set;}

	}
}
