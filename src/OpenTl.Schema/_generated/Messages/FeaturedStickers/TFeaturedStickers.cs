// ReSharper disable All

namespace OpenTl.Schema.Messages
{
	using System;
	using System.Collections;
	using System.Text;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0xf89d88e5)]
	public sealed class TFeaturedStickers : IFeaturedStickers
	{
       [SerializationOrder(0)]
       public int Hash {get; set;}

       [SerializationOrder(1)]
       public OpenTl.Schema.TVector<OpenTl.Schema.IStickerSetCovered> Sets {get; set;}

       [SerializationOrder(2)]
       public OpenTl.Schema.TVector<long> Unread {get; set;}

	}
}
