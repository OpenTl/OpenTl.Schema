// ReSharper disable All

namespace OpenTl.Schema.Messages
{
	using System;
	using System.Collections;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0x5ce20970)]
	public class TRecentStickers : IRecentStickers
	{
       [SerializationOrder(0)]
       public int Hash {get; set;}

       [SerializationOrder(1)]
       public TVector<IDocument> Stickers {get; set;}

	}
}
