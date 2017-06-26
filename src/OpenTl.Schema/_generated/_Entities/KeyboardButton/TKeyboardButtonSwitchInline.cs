// ReSharper disable All

namespace OpenTl.Schema
{
	using System;
	using System.Collections;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0x568a748)]
	public class TKeyboardButtonSwitchInline : IKeyboardButton
	{
       [SerializationOrder(0)]
       public BitArray Flags {get; set;}

       [SerializationOrder(1)]
       [FromFlag("Flags", 0)]
       public bool SamePeer {get; set;}

       [SerializationOrder(2)]
       public string Text {get; set;}

       [SerializationOrder(3)]
       public string Query {get; set;}

	}
}
