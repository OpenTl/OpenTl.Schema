// ReSharper disable All

namespace OpenTl.Schema
{
	using System;
	using System.Collections;
	using System.Text;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0x77608b83)]
	public sealed class TKeyboardButtonRow : IKeyboardButtonRow
	{
       [SerializationOrder(0)]
       public OpenTl.Schema.TVector<OpenTl.Schema.IKeyboardButton> Buttons {get; set;}

	}
}
