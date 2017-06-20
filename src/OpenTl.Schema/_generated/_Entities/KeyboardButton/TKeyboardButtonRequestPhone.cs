namespace OpenTl.Schema
{
	using System;
	using System.Collections;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0xb16a6c29)]
	public class TKeyboardButtonRequestPhone : IKeyboardButton
	{
       [SerializationOrder(0)]
       public string Ext {get; set;}

	}
}
