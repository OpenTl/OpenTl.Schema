// ReSharper disable All

namespace OpenTl.Schema
{
	using System;
	using System.Collections;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0xfc796b3f)]
	public class TKeyboardButtonRequestGeoLocation : IKeyboardButton
	{
       [SerializationOrder(0)]
       public string Ext {get; set;}

	}
}
