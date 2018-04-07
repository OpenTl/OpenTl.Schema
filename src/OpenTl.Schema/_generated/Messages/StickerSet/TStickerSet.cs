// ReSharper disable All

namespace OpenTl.Schema.Messages
{
	using System;
	using System.Collections;
	using System.Text;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0xb60a24a6)]
	public sealed class TStickerSet : IStickerSet
	{
       [SerializationOrder(0)]
       public OpenTl.Schema.IStickerSet Set {get; set;}

       [SerializationOrder(1)]
       public OpenTl.Schema.TVector<OpenTl.Schema.IStickerPack> Packs {get; set;}

       [SerializationOrder(2)]
       public OpenTl.Schema.TVector<OpenTl.Schema.IDocument> Documents {get; set;}

	}
}
