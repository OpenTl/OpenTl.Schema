// ReSharper disable All

namespace OpenTl.Schema
{
	using System;
	using System.Collections;
	using System.Text;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0x6e947941)]
	public sealed class TUpdateChatAdmins : IUpdate
	{
       [SerializationOrder(0)]
       public int ChatId {get; set;}

       [SerializationOrder(1)]
       public bool Enabled {get; set;}

       [SerializationOrder(2)]
       public int Version {get; set;}

	}
}
