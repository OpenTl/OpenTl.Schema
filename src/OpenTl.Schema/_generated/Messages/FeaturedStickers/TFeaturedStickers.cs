// ReSharper disable All

namespace OpenTl.Schema.Messages
{
	using System;
	using System.Collections;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0xf89d88e5)]
	public class TFeaturedStickers : IFeaturedStickers
	{
       [SerializationOrder(0)]
       public int Hash {get; set;}

       [SerializationOrder(1)]
       public TVector<IStickerSetCovered> Sets {get; set;}

       [SerializationOrder(2)]
       public TVector<long> Unread {get; set;}

	}
}
