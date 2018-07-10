// ReSharper disable All

namespace OpenTl.Schema.Messages
{
	using System;
	using System.Collections;
	using System.Text;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0xf0e3e596)]
	public sealed class TDialogsNotModified : IDialogs
	{
       [SerializationOrder(0)]
       public int Count {get; set;}

	}
}
