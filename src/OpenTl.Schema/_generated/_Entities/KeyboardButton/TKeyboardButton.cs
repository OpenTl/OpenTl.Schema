namespace OpenTl.Schema
{
	using System;
	using System.Collections;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0xa2fa4880)]
	public class TKeyboardButton : IKeyboardButton
	{
       [SerializationOrder(0)]
       public string Ext {get; set;}

	}
}
