// ReSharper disable All

namespace OpenTl.Schema
{
	using System;
	using System.Collections;
	using System.Text;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0xbad88395)]
	public sealed class TInputMessageReplyTo : IInputMessage
	{
       [SerializationOrder(0)]
       public int Id {get; set;}

	}
}
