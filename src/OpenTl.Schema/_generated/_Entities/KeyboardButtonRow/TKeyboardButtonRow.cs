namespace OpenTl.Schema
{
	using System;
	using System.Collections;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0x77608b83)]
	public class TKeyboardButtonRow : IKeyboardButtonRow
	{
       [SerializationOrder(0)]
       public TVector<IKeyboardButton> Buttons {get; set;}

	}
}
