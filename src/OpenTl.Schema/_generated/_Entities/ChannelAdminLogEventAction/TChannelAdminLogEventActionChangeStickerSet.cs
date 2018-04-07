// ReSharper disable All

namespace OpenTl.Schema
{
	using System;
	using System.Collections;
	using System.Text;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0xb1c3caa7)]
	public sealed class TChannelAdminLogEventActionChangeStickerSet : IChannelAdminLogEventAction
	{
       [SerializationOrder(0)]
       public OpenTl.Schema.IInputStickerSet PrevStickerset {get; set;}

       [SerializationOrder(1)]
       public OpenTl.Schema.IInputStickerSet NewStickerset {get; set;}

	}
}
