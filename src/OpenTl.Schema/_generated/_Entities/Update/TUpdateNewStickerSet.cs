// ReSharper disable All

namespace OpenTl.Schema
{
	using System;
	using System.Collections;
	using System.Text;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0x688a30aa)]
	public sealed class TUpdateNewStickerSet : IUpdate
	{
       [SerializationOrder(0)]
       public OpenTl.Schema.Messages.IStickerSet Stickerset {get; set;}

	}
}
