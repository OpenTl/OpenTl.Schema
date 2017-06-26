// ReSharper disable All

namespace OpenTl.Schema
{
	using System;
	using System.Collections;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0x1f486803)]
	public class TExportedMessageLink : IExportedMessageLink
	{
       [SerializationOrder(0)]
       public string Link {get; set;}

	}
}
