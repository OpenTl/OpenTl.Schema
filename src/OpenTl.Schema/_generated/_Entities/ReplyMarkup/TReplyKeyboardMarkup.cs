// ReSharper disable All

namespace OpenTl.Schema
{
	using System;
	using System.Collections;
	using System.Text;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0x3502758c)]
	public sealed class TReplyKeyboardMarkup : IReplyMarkup
	{
       [SerializationOrder(0)]
       public BitArray Flags {get; set;}

       [SerializationOrder(1)]
       [FromFlag("Flags", 0)]
       public bool Resize {get; set;}

       [SerializationOrder(2)]
       [FromFlag("Flags", 1)]
       public bool SingleUse {get; set;}

       [SerializationOrder(3)]
       [FromFlag("Flags", 2)]
       public bool Selective {get; set;}

       [SerializationOrder(4)]
       public OpenTl.Schema.TVector<OpenTl.Schema.IKeyboardButtonRow> Rows {get; set;}

	}
}
