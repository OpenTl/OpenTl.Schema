// ReSharper disable All

namespace OpenTl.Schema.Messages
{
	using System;
	using System.Collections;
	using System.Text;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0x22f3afb3)]
	public sealed class TRecentStickers : IRecentStickers
	{
       [SerializationOrder(0)]
       public int Hash {get; set;}

       [SerializationOrder(1)]
       public OpenTl.Schema.TVector<OpenTl.Schema.IStickerPack> Packs {get; set;}

       [SerializationOrder(2)]
       public OpenTl.Schema.TVector<OpenTl.Schema.IDocument> Stickers {get; set;}

       [SerializationOrder(3)]
       public OpenTl.Schema.TVector<int> Dates {get; set;}

	}
}
