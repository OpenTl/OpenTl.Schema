// ReSharper disable All

namespace OpenTl.Schema
{
	using System;
	using System.Collections;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0x9bf8bb95)]
	public class TTextStrike : IRichText
	{
       [SerializationOrder(0)]
       public IRichText Ext {get; set;}

	}
}
