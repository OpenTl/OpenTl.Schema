// ReSharper disable All

namespace OpenTl.Schema
{
	using System;
	using System.Collections;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0x258aff05)]
	public class TKeyboardButtonUrl : IKeyboardButton
	{
       [SerializationOrder(0)]
       public string Ext {get; set;}

       [SerializationOrder(1)]
       public string Url {get; set;}

	}
}
