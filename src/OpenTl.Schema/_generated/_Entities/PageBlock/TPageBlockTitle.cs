// ReSharper disable All

namespace OpenTl.Schema
{
	using System;
	using System.Collections;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0x70abc3fd)]
	public class TPageBlockTitle : IPageBlock
	{
       [SerializationOrder(0)]
       public IRichText Ext {get; set;}

	}
}
