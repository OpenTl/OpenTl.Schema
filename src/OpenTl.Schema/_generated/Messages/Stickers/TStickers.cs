namespace OpenTl.Schema.Messages
{
	using System;
	using System.Collections;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0x8a8ecd32)]
	public class TStickers : IStickers
	{
       [SerializationOrder(0)]
       public string Hash {get; set;}

       [SerializationOrder(1)]
       public TVector<IDocument> Stickers {get; set;}

	}
}
