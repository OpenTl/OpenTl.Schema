// ReSharper disable All

namespace OpenTl.Schema
{
	using System;
	using System.Collections;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0x861cc8a0)]
	public class TInputStickerSetShortName : IInputStickerSet
	{
       [SerializationOrder(0)]
       public string ShortName {get; set;}

	}
}
