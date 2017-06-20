namespace OpenTl.Schema.Messages
{
	using System;
	using System.Collections;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0xb60a24a6)]
	public class TStickerSet : IStickerSet
	{
       [SerializationOrder(0)]
       public IStickerSet Set {get; set;}

       [SerializationOrder(1)]
       public TVector<IStickerPack> Packs {get; set;}

       [SerializationOrder(2)]
       public TVector<IDocument> Documents {get; set;}

	}
}
