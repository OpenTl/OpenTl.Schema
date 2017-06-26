// ReSharper disable All

namespace OpenTl.Schema
{
	using System;
	using System.Collections;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0x6c3f19b9)]
	public class TTextFixed : IRichText
	{
       [SerializationOrder(0)]
       public IRichText Ext {get; set;}

	}
}
