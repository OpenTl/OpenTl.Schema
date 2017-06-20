namespace OpenTl.Schema
{
	using System;
	using System.Collections;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0x50f41ccf)]
	public class TKeyboardButtonGame : IKeyboardButton
	{
       [SerializationOrder(0)]
       public string Ext {get; set;}

	}
}
