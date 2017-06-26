// ReSharper disable All

namespace OpenTl.Schema
{
	using System;
	using System.Collections;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0x6724abc4)]
	public class TTextBold : IRichText
	{
       [SerializationOrder(0)]
       public IRichText Ext {get; set;}

	}
}
