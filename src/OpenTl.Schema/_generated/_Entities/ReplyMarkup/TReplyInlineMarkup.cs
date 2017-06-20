namespace OpenTl.Schema
{
	using System;
	using System.Collections;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0x48a30254)]
	public class TReplyInlineMarkup : IReplyMarkup
	{
       [SerializationOrder(0)]
       public TVector<IKeyboardButtonRow> Rows {get; set;}

	}
}
