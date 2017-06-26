// ReSharper disable All

namespace OpenTl.Schema
{
	using System;
	using System.Collections;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0x7328bdb)]
	public class TChatForbidden : IChat
	{
       [SerializationOrder(0)]
       public int Id {get; set;}

       [SerializationOrder(1)]
       public string Title {get; set;}

	}
}
