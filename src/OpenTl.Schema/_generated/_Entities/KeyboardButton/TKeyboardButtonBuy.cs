// ReSharper disable All

namespace OpenTl.Schema
{
	using System;
	using System.Collections;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0xafd93fbb)]
	public class TKeyboardButtonBuy : IKeyboardButton
	{
       [SerializationOrder(0)]
       public string Ext {get; set;}

	}
}
