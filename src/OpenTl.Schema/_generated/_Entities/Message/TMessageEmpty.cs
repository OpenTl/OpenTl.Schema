// ReSharper disable All

namespace OpenTl.Schema
{
	using System;
	using System.Collections;
	using System.Text;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0x83e5de54)]
	public sealed class TMessageEmpty : IMessage, IEmpty
	{
       [SerializationOrder(0)]
       public int Id {get; set;}

	}
}
