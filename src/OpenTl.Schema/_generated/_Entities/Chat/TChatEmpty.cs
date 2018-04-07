// ReSharper disable All

namespace OpenTl.Schema
{
	using System;
	using System.Collections;
	using System.Text;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0x9ba2d800)]
	public sealed class TChatEmpty : IChat, IEmpty
	{
       [SerializationOrder(0)]
       public int Id {get; set;}

	}
}
